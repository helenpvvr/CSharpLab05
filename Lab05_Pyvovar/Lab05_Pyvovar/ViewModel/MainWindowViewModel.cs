using Lab05_Pyvovar.Tools;
using Lab05_Pyvovar.Tools.Managers;
using System.Collections.Specialized;
using System.Windows;

namespace Lab05_Pyvovar.ViewModel
{
    internal class MainWindowViewModel : BaseViewModel, ILoaderOwner
    {

        #region Fields
        private Visibility _loaderVisibility = Visibility.Hidden;
        private bool _isControlEnabled = true;
        #endregion

        #region Properties
        public Visibility LoaderVisibility
        {
            get { return _loaderVisibility; }
            set
            {
                _loaderVisibility = value;
                OnPropertyChanged();
            }
        }
        public bool IsControlEnabled
        {
            get { return _isControlEnabled; }
            set
            {
                _isControlEnabled = value;
                OnPropertyChanged();
            }
        }
        #endregion

        internal MainWindowViewModel()
        {
            LoaderManager.Instance.Initialize(this);
        }

        event NotifyCollectionChangedEventHandler INotifyCollectionChanged.CollectionChanged
        {
            add
            {
                throw new System.NotImplementedException();
            }

            remove
            {
                throw new System.NotImplementedException();
            }
        }

        public event NotifyCollectionChangedEventHandler CollectionChanged;

        internal override void RefreshInfo()
        {

        }
    }
}