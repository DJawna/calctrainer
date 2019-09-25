using CalctrainerContracts.models;
using CalctrainerContracts.repositories;
using System;

namespace CalcTrainer.Core.ViewModels
{
    internal class MainWindowViewModel<T> : BaseViewModel
    {
        private readonly T avaitingControl;
        

        private readonly IProfileRepository profileRepository;
        private Profile currentProfile;

        public MainWindowViewModel(IProfileRepository profileRepository, T avaitingControl)
        {
            this.profileRepository = profileRepository;
            this.avaitingControl = avaitingControl;
            Subcontrol = this.avaitingControl;
        }

        public T Subcontrol { get; set; }


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
