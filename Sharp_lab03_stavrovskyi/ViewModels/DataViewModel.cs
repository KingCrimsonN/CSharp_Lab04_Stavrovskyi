using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using Sharp_lab03_stavrovskyi.Managers;
using Sharp_lab03_stavrovskyi.Models;
using Sharp_lab03_stavrovskyi.Tools.Managers;
using Sharp_lab03_stavrovskyi.Tools.Navigation;

namespace Sharp_lab03_stavrovskyi.ViewModels
{
    class DataViewModel : INotifyPropertyChanged
    {
        private ObservableCollection<Person> _users;
        private ICommand _returnCommand;


        public ObservableCollection<Person> Users
        {
            get => _users;
            private set
            {
                _users = value;
                OnPropertyChanged();
            }
        }

        internal DataViewModel()
        {
            _users = new ObservableCollection<Person>(StationManager.DataStorage.UserList);
            
        }

        public ICommand ReturnCommand
        {
            get { return _returnCommand ?? (_returnCommand = new RelayCommand<object>(ReturnImplementation)); }
        }

        private void ReturnImplementation(object o)
        {
            NavigationManager.Instance.Navigate(ViewType.Login);
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
