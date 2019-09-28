using CalctrainerContracts.models;
using CalctrainerContracts.repositories;
using System;

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
            this.avaitingControl.AvaitMessage = Properties.Resources.MenuItem_LoadProfile;
            Subcontrol = this.avaitingControl;

            profileRepository.GetLastProfileByMachineName(Environment.MachineName)
                .ContinueWith(i =>
                {
                    currentProfile = i.Result;
                    Subcontrol = new ProfileStatsViewModel(currentProfile);
                });
        }

        public BaseViewModel Subcontrol { get; set; }





        public bool ProfileDirty
        {
            get;set;
        }

    }
}
