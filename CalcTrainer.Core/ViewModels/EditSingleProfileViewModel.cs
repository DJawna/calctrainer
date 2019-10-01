using CalcTrainer.Core.Commands;
using CalctrainerContracts.models;
using CalctrainerContracts.repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace CalcTrainer.Core.ViewModels
{
    /// <summary>
    /// Viewmodel to edit a single <see cref="Profile"/> record
    /// </summary>
    class EditSingleProfileViewModel : BaseViewModel
    {
        private readonly IProfileRepository profileRepository;
        private string profileName;

        /// <summary>
        /// </summary>
        /// <param name="profileRepository">used to save the <see cref="Profile"/> if the user decides to save the changes</param>
        /// <param name="profile">the <see cref="Profile"/> to display and / or modify</param>
        public EditSingleProfileViewModel(IProfileRepository profileRepository, Profile profile)
        {
            
            this.profileRepository = profileRepository;
            SaveModified = new ActionCommand(() =>
            {
                this.profileRepository
                .SaveProfile(new Profile(ProfileName))
                .ContinueWith(i =>
                {
                    if (i.IsCompleted && !i.IsFaulted)
                    {
                        Modified = false;
                    }
                });

            },() => Modified);
        }

        /// <summary>
        /// true if <see cref="Profile"/> has been changed
        /// </summary>
        public bool Modified { get; set; }

        /// <summary>
        /// save the <see cref="Profile"/>
        /// </summary>
        public ICommand SaveModified { get; private set; }

        
        public string ProfileName 
        {
            get => profileName;
            
            set 
            {
                if (profileName == value)
                {
                    return;
                }
                profileName = value;
                Modified = true;

            }
        }
    }
}
