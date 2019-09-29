using Autofac;
using CalcTrainer.Core.ViewModels;
using CalctrainerContracts.repositories;
using System.Windows;
using System.Windows.Controls;

namespace CalcTrainer.Core.Views
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            DataContext = new MainWindowViewModel(App.iocScope.Resolve<IProfileRepository>());
        }

        private void ExitClick(object sender, RoutedEventArgs e)
        {
            System.Windows.Application.Current.Shutdown();
        }


    }
}
