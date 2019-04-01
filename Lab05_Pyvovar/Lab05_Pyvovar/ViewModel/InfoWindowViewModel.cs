using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Lab05_Pyvovar.Tools.Managers;

namespace Lab05_Pyvovar.ViewModel
{
    internal class InfoWindowViewModel : INotifyPropertyChanged
    {

        private ObservableCollection<Process> _processes;
        private Process _selectedProcess;

        public ObservableCollection<Process> Processes
        {
            get { return _processes; }
            private set
            {
                _processes = value;
                OnPropertyChanged();
            }
        }

        public Process SelectedProcess
        {
            private get { return _selectedProcess; }
            set
            {
                _selectedProcess = value;
                OnPropertyChanged();
            }
        }

        internal InfoWindowViewModel()
        {
            _processes = new ObservableCollection<Process>(StationManager.DataStorage.ProcessList);
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public void Refresh()
        {

        }
    }
}