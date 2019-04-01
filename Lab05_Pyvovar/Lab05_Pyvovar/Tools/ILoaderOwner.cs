﻿using System.Collections.Specialized;
using System.Windows;

namespace Lab05_Pyvovar.Tools
{
    interface ILoaderOwner : INotifyCollectionChanged
    {
        Visibility LoaderVisibility { get; set; }
        bool IsControlEnabled { get; set; }
    }
}