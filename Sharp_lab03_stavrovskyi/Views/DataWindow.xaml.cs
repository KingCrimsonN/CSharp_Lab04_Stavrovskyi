using System.Windows.Controls;
using Sharp_lab03_stavrovskyi.Tools.Navigation;
using Sharp_lab03_stavrovskyi.ViewModels;

namespace Sharp_lab03_stavrovskyi.Views
{
   
    public partial class DataWindow : UserControl, INavigatable, IUpdatable
    {
        public DataWindow()
        {
            InitializeComponent();
            DataContext = new DataViewModel();
        }

        public void Update()
        {
            ((DataViewModel)DataContext).Update();
        }
    }
}
