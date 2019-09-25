using CalctrainerContracts.models;
using CalctrainerContracts.repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace CalcTrainer.Core
{
    public class MainWindowViewModel : INotifyPropertyChanged
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

        public event PropertyChangedEventHandler PropertyChanged = (sender,e) => { };
    }
}
