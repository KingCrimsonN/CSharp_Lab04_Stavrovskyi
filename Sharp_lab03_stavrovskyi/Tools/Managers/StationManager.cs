using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using Sharp_lab03_stavrovskyi.DataStorage;
using Sharp_lab03_stavrovskyi.Models;

namespace Sharp_lab03_stavrovskyi.Tools.Managers
{
    internal static class StationManager
    {
        public static event Action StopThreads;

        private static IDataStorage _dataStorage;

        internal static Person CurrentUser { get; set; }

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
            MessageBox.Show("ShutDown");
            StopThreads?.Invoke();
            Environment.Exit(1);
        }
    }
}
