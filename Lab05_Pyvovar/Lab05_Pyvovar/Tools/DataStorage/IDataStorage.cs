using System.Collections.Generic;
using System.Diagnostics;

namespace Lab05_Pyvovar.Tools.DataStorage
{
    internal interface IDataStorage
    {
        void AddProcess(Process process);
        void RemoveProcess(Process process);
        List<Process> ProcessList { get; }
    }
}