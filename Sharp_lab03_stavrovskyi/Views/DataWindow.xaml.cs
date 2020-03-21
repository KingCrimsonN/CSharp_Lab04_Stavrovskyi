using System.Windows.Controls;
using Sharp_lab03_stavrovskyi.Tools.Navigation;
using Sharp_lab03_stavrovskyi.ViewModels;

namespace Sharp_lab03_stavrovskyi.Views
{
    /// <summary>
    /// Interaction logic for DataWindow.xaml
    /// </summary>
    public partial class DataWindow : UserControl, INavigatable
    {
        public DataWindow()
        {
            InitializeComponent();
            DataContext = new MainWindowViewModel();
        }
    }
}
