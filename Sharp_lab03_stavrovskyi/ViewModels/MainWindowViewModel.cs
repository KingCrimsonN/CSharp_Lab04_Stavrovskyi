using System.Windows;
using System.Windows.Input;
using Sharp_lab03_stavrovskyi.Managers;
using Sharp_lab03_stavrovskyi.Tools;
using Sharp_lab03_stavrovskyi.Tools.Navigation;

namespace Sharp_lab03_stavrovskyi.ViewModels
{
    class MainWindowViewModel : BaseViewModel, ILoaderOwner
    {
        #region Fields
        private Visibility _loaderVisibility = Visibility.Hidden;
        private bool _isControlEnabled = true;
        
        #endregion

        #region Properties
        public Visibility LoaderVisibility
        {
            get { return _loaderVisibility; }
            set
            {
                _loaderVisibility = value;
                OnPropertyChanged();
            }
        }
        public bool IsControlEnabled
        {
            get { return _isControlEnabled; }
            set
            {
                _isControlEnabled = value;
                OnPropertyChanged();
            }
        }
        #endregion

        internal MainWindowViewModel()
        {
            LoaderManager.Instance.Initialize(this);
        }

        #region Commands

       

        #endregion
    }
}