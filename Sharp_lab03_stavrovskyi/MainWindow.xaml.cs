
using System.Windows;
using System.Windows.Controls;
using Sharp_lab03_stavrovskyi.Managers;
using Sharp_lab03_stavrovskyi.Tools.Navigation;
using Sharp_lab03_stavrovskyi.ViewModels;

namespace Sharp_lab03_stavrovskyi
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, IContentOwner
    {
        public ContentControl ContentControl
        {
            get { return _contentControl; }
        }
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new MainWindowViewModel();
            NavigationManager.Instance.Initialize(new InitializationNavigationModel(this));
            NavigationManager.Instance.Navigate(ViewType.Login);
        }
    }
}
