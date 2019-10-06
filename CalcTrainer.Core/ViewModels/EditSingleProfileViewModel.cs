using CalcTrainer.Core.Commands;
using CalctrainerContracts.models;
using CalctrainerContracts.repositories;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Input;

[assembly: InternalsVisibleToAttribute("CalcTrainer.Core.Tests")]
namespace CalcTrainer.Core.ViewModels
{
    /// <summary>
    /// Viewmodel to edit a single <see cref="Profile"/> record
    /// </summary>
 
    class EditSingleProfileViewModel : BaseViewModel
    {
        private readonly IProfileRepository profileRepository;
        private string profileName;
        private ActionCommand _saveModified;
        private bool _modified;

        /// <summary>
        /// </summary>
        /// <param name="profileRepository">used to save the <see cref="Profile"/> if the user decides to save the changes</param>
        /// <param name="profile">the <see cref="Profile"/> to display and / or modify</param>
        public EditSingleProfileViewModel(IProfileRepository profileRepository, Profile profile)
        {
            
            this.profileRepository = profileRepository;
            _saveModified = new ActionCommand((self) =>
            {
                self.CommandIsEnabled = false;
                this.profileRepository
                .SaveProfile(new Profile(ProfileName))
                .ContinueWith(i =>
                {
                    if (i.IsCompleted && !i.IsFaulted)
                    {
                        Modified = false;
                    }
                    else 
                    {
                        Modified = true;
                    }

                });

            });
            _saveModified.CommandIsEnabled = false;
        }

        /// <summary>
        /// true if <see cref="Profile"/> has been changed
        /// </summary>
        public bool Modified 
        { 
            get => _modified;
            set 
            {
                _modified = value;
                _saveModified.CommandIsEnabled = Modified;
            } 
        }

        /// <summary>
        /// save the <see cref="Profile"/>
        /// </summary>
        public ICommand SaveModified 
        { 
            get => _saveModified;
        }

        
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
