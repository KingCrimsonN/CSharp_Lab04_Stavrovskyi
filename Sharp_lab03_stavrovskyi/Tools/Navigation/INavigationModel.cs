using System;
using System.Collections.Generic;
using System.Text;

namespace Sharp_lab03_stavrovskyi.Tools.Navigation
{
    internal enum ViewType
    {
       Login,
       Data
    }

    interface INavigationModel
    {
        void Navigate(ViewType viewType);
    }
}
