using CalcTrainer.Core.ViewModels;
using System.Windows.Controls;

namespace CalcTrainer.Core.Views
{
    /// <summary>
    /// Interaction logic for ProfileStatsView.xaml
    /// </summary>
    public partial class ProfileStatsView : UserControl
    {

        public ProfileStatsView(BaseViewModel baseViewModel)
        {
            InitializeComponent();
            this.DataContext = baseViewModel;
        }
    }
}
