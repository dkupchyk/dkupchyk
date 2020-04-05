using System;
using Lab5_Kupchyk.Views;

namespace Lab5_Kupchyk.Tools.Navigation
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
                case ViewType.TaskManager:
                    ViewsDictionary.Add(viewType,new TaskManagerView());
                    break;
                case ViewType.ThreadsModules:
                    ViewsDictionary.Add(viewType, new ThreadsModulesView());
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(viewType), viewType, null);
            }
        }
    }
}
