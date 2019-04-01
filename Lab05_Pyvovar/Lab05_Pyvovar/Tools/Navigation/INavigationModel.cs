namespace Lab05_Pyvovar.Tools.Navigation
{
    internal enum ViewType
    {
        Info
    }

    interface INavigationModel
    {
        void Navigate(ViewType viewType);
    }
}