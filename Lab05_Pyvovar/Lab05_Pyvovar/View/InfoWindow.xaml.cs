using System.Windows.Controls;
using Lab05_Pyvovar.Tools.Navigation;
using Lab05_Pyvovar.ViewModel;

namespace Lab05_Pyvovar.View
{
    /// <summary>
    /// Interaction logic for InfoWindow.xaml
    /// </summary>
    public partial class InfoWindow : UserControl, INavigatable
    {
        private readonly InfoWindowViewModel _infoWindowViewModel = new InfoWindowViewModel();

        public InfoWindow()
        {
            InitializeComponent();
            DataContext = _infoWindowViewModel;
        }

        INavigatable INavigatable.RefreshInfo()
        {
            _infoWindowViewModel.Refresh();
            return this;
        }
    }
}
