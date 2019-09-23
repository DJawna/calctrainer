﻿using Autofac;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace Calctrainer
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static IContainer IocContainer;

        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            IocContainer = IocConfig.Configure();
            
        }
    }
}
