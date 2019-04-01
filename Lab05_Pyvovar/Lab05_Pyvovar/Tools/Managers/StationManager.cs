using Lab05_Pyvovar.Tools.DataStorage;
using System;
using System.Diagnostics;

namespace Lab05_Pyvovar.Tools.Managers
{
    internal static class StationManager
    {
        public static event Action StopThreads;

        private static IDataStorage _dataStorage;

        internal static Process CurrentProcess { get; set; }

        internal static IDataStorage DataStorage
        {
            get { return _dataStorage; }
        }

        internal static void Initialize(IDataStorage dataStorage)
        {
            _dataStorage = dataStorage;
        }

        internal static void CloseApp()
        {
            Environment.Exit(1);
        }
    }
}