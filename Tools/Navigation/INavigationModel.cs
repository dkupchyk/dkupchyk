namespace Lab5_Kupchyk.Tools.Navigation
{
    internal enum ViewType
    {
        TaskManager,
        ThreadsModules
    }

    interface INavigationModel
    {
        void Navigate(ViewType viewType);
    }
}
