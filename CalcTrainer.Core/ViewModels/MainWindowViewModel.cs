using CalcTrainer.Core.Commands;
using CalctrainerContracts.models;
using CalctrainerContracts.repositories;
using System;
using System.Windows.Input;

namespace CalcTrainer.Core.ViewModels
{
    internal class MainWindowViewModel : BaseViewModel
    {
        private readonly AvaitingViewModel avaitingControl;
        private readonly ProfileStatsViewModel profileStatsViewModel;
        private readonly TrainingViewModel trainingViewModel;

        private readonly IProfileRepository profileRepository;
        private Profile currentProfile;

        public MainWindowViewModel(IProfileRepository profileRepository)
        {
            this.profileRepository = profileRepository;
            this.avaitingControl = new AvaitingViewModel();
            this.trainingViewModel = new TrainingViewModel();
            
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

        public ICommand ShowProfileStatsView => new ActionCommand((self) => Subcontrol = profileStatsViewModel);

   

        public ICommand ShowTrainingViewModel => new ActionCommand((self) => Subcontrol = trainingViewModel);

        public bool ProfileDirty
        {
            get;set;
        }

    }
}
