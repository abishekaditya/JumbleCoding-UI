﻿using JumbleCoding.Managers;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace JumbleCoding
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnExit(ExitEventArgs e)
        {
            Manager.Finalize();
            base.OnExit(e);
        }

        protected override void OnStartup(StartupEventArgs e)
        {
            Manager.Initialize();
            base.OnStartup(e);
        }
    }
}
