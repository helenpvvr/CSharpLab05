using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Lab05_Pyvovar.Models;

namespace Lab05_Pyvovar.Tools.DataStorage
{
    internal class ProcessDataStorage : IDataStorage
    {
        private List<Process> _processes;
        private List<SystemProcess> _systemProcesses;

        internal ProcessDataStorage()
        {
            _processes = Process.GetProcesses().ToList();

            _systemProcesses = new List<SystemProcess>();
            foreach (var pr in Process.GetProcesses().ToList())
            {
                _systemProcesses.Add(new SystemProcess(pr));
            }
        }

        public void AddProcess(Process process)
        {
            _processes.Add(process);
        }

        public void RemoveProcess(Process process)
        {
            _processes.Remove(process);
        }

        public List<Process> ProcessList
        {
            get { return _processes.ToList(); }
            set { _processes = value; }
        }

        //public void Sort(SortBy sort)
        //{
        //    PeopleList = Sorting.ToSortBy(sort);
        //    SaveChanges();
        //}
    }
}