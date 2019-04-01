using System;
using System.Diagnostics;

namespace Lab05_Pyvovar.Models
{
    internal class SystemProcess
    {
        private readonly string _nameProcess;
        private readonly int _id;
        private bool _isActive;
        private double _percentageCPU;
        private double _capacityRAM;
        private int _numberThread;
        private string _nameUser;
        private string _pathToFile;
        private DateTime _startDateTime;

        private ProcessModuleCollection _modules;
        private ProcessThreadCollection _threads;

        public SystemProcess(Process process)
        {
            _nameProcess = process.ProcessName;
            _id = process.Id;
            RefreshInfo(process);
        }

        public string NameProcess => _nameProcess;
        public int Id => _id;

        public bool IsActive
        {
            get { return _isActive; }
            private set { _isActive = value; }
        }
        
        public double PercentageCPU
        {
            get { return _percentageCPU; }
            private set { _percentageCPU = value; }
        }
        
        public double CapacityRAM
        {
            get { return _capacityRAM; }
            private set { _capacityRAM = value; }
        }
        
        public int NumberThread
        {
            get { return _numberThread; }
            private set { _numberThread = value; }
        }
        
        public string NameUser
        {
            get { return _nameUser; }
            private set { _nameUser = value; }
        }
        
        public string PathToFile
        {
            get { return _pathToFile; }
            private set { _pathToFile = value; }
        }
        
        public DateTime StartDateTime
        {
            get { return _startDateTime; }
            private set { _startDateTime = value; }
        }
        
        public ProcessModuleCollection Modules
        {
            get { return _modules; }
            private set { _modules = value; }
        }
        
        public ProcessThreadCollection Threads
        {
            get { return _threads; }
            private set { _threads = value; }
        }

        internal void RefreshInfo(Process process)
        {
            IsActive = !process.HasExited; // check
            PercentageCPU = new PerformanceCounter("Process", "% Processor Time", _nameProcess).NextValue();
            CapacityRAM = new PerformanceCounter("Process", "Working Set", _nameProcess).NextValue(); // VirtualMemorySize64
            NumberThread = process.Threads.Count;
            NameUser = process.MachineName;
            PathToFile = process.MainModule.FileName;
            StartDateTime = process.StartTime;

            Modules = process.Modules; // ModuleName and FileName
            Threads = process.Threads; // Id, стан, StartTime
        }
    }
}