using System;
using Sharp_lab03_stavrovskyi.Views;

namespace Sharp_lab03_stavrovskyi.Tools.Navigation
{
    internal class InitializationNavigationModel : BaseNavigationModel
    {
        public InitializationNavigationModel(IContentOwner contentOwner) : base(contentOwner)
        {

        }

        protected override void InitializeView(ViewType viewType)
        {
            switch (viewType)
            {
                case ViewType.Login:
                    ViewsDictionary.Add(viewType, new LoginWindow());
                    break;
                case ViewType.Data:
                    ViewsDictionary.Add(viewType, new DataWindow());
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(viewType), viewType, null);
            }
        }
    }
}
