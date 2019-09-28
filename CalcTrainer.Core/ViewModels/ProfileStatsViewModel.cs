using CalctrainerContracts.models;

namespace CalcTrainer.Core.ViewModels
{
    class ProfileStatsViewModel : BaseViewModel
    {
        public Profile CurrentProfile { get; set; }
       
        public ProfileStatsViewModel(Profile currentProfile)
        {
            CurrentProfile = currentProfile;
                
        }
    }
}
