using System.Windows.Controls;
using Sharp_lab03_stavrovskyi.Tools.Navigation;
using Sharp_lab03_stavrovskyi.ViewModels;

namespace Sharp_lab03_stavrovskyi
{
    /// <summary>
    /// Interaction logic for LoginWindow.xaml
    /// </summary>
    public partial class LoginWindow : UserControl, INavigatable
    {
        public LoginWindow()
        {
            InitializeComponent();
            DataContext = new LoginViewModel();
        }
    }
}
