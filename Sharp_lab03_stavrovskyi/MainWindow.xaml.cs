
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using Sharp_lab03_stavrovskyi.DataStorage;
using Sharp_lab03_stavrovskyi.Managers;
using Sharp_lab03_stavrovskyi.Tools.Managers;
using Sharp_lab03_stavrovskyi.Tools.Navigation;
using Sharp_lab03_stavrovskyi.ViewModels;

namespace Sharp_lab03_stavrovskyi
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, IContentOwner
    {
        private SerializedDataStorage _serializedDataStorage;
        public ContentControl ContentControl
        {
            get { return _contentControl; }
        }
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new MainWindowViewModel();
            _serializedDataStorage = new SerializedDataStorage();
            StationManager.Initialize(_serializedDataStorage);
            NavigationManager.Instance.Initialize(new InitializationNavigationModel(this));
            NavigationManager.Instance.Navigate(ViewType.Login);
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            _serializedDataStorage.SaveChanges();
            base.OnClosing(e);
            StationManager.CloseApp();
        }
    }
}
