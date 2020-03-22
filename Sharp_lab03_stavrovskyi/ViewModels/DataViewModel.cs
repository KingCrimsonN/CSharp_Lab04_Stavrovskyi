using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Input;
using Sharp_lab03_stavrovskyi.Managers;
using Sharp_lab03_stavrovskyi.Models;
using Sharp_lab03_stavrovskyi.Tools.Managers;
using Sharp_lab03_stavrovskyi.Tools.Navigation;

namespace Sharp_lab03_stavrovskyi.ViewModels
{
    class DataViewModel : INotifyPropertyChanged
    {
        #region Fields

        

        
        private ObservableCollection<Person> _users;
        private Person _currentUser;
        private ICommand _returnCommand;
        private ICommand _deleteCommand;
        #endregion

        #region Properties

        public Person CurrentUser
        {
            get { return _currentUser; }
            set
            {
                _currentUser = value;
                OnPropertyChanged();
            }
        }

        public ObservableCollection<Person> Users
        {
            get => _users;
            private set
            {
                _users = value;
                OnPropertyChanged();
            }
        }

        #endregion

        internal DataViewModel()
        {
            _users = new ObservableCollection<Person>(StationManager.DataStorage.UserList);
            
        }

        #region Commands

        public void Update()
        {
            //_users = new ObservableCollection<Person>(StationManager.DataStorage.UserList);
        }

        public ICommand DeleteCommand
        {
            get { return _deleteCommand ?? (_deleteCommand = new RelayCommand<object>(DeleteUser)); }
        }

        private void DeleteUser(object o)
        {
            if (CurrentUser != null)
            {
                MessageBox.Show("Deleting the user");

                StationManager.DataStorage.DeleteUser(CurrentUser);
                Users.Remove(_currentUser);
            }
            else
            {
                MessageBox.Show("Please, select a user first!");
            }
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
        #endregion
    }
}
