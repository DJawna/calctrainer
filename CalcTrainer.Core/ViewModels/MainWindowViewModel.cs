using CalctrainerContracts.models;
using CalctrainerContracts.repositories;
using System;

namespace CalcTrainer.Core.ViewModels
{
    internal class MainWindowViewModel : BaseViewModel
    {

        

        private readonly IProfileRepository profileRepository;
        private Profile currentProfile;

        public MainWindowViewModel(IProfileRepository profileRepository)
        {
            this.profileRepository = profileRepository;
            profileRepository.GetLastProfileByMachineName(Environment.MachineName)
                .ContinueWith(i => 
                {
                    if (!i.IsFaulted)
                    {
                        currentProfile = i.Result;
                        ProfileName = currentProfile.Name;
                    }
                });
        }


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
