using Autofac;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace CalcTrainer.Core
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private IContainer IocContainer;
        public static ILifetimeScope iocScope;

        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            IocContainer = IocConfig.Configure();

            iocScope = IocContainer.BeginLifetimeScope();



        }

        protected override void OnExit(ExitEventArgs e)
        {
            base.OnExit(e);
            iocScope.Dispose();
        }
    }
}
