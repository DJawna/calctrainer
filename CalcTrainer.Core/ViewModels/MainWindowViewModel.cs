using CalctrainerContracts.models;
using CalctrainerContracts.repositories;

namespace CalcTrainer.Core.ViewModels
{
    internal class MainWindowViewModel : BaseViewModel
    {
        private readonly AvaitingViewModel avaitingControl;
        

        private readonly IProfileRepository profileRepository;
        private Profile currentProfile;

        public MainWindowViewModel(IProfileRepository profileRepository, AvaitingViewModel avaitingControl)
        {
            this.profileRepository = profileRepository;
            this.avaitingControl = avaitingControl;
            Subcontrol = this.avaitingControl;
        }

        public BaseViewModel Subcontrol { get; set; }


        public string ProfileName
        {
            get;set;
        }



        public bool ProfileDirty
        {
            get;set;
        }

    }
}
