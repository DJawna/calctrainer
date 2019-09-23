using Calctrainer.repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Calctrainer
{
    public class MainWindowViewModel : DependencyObject
    {
        #region DependencyPropertyStaticBoylerplateCode

        public static readonly DependencyProperty ProfileNameProperty =
            DependencyProperty.Register("ProfileNameProperty", typeof(string), typeof(MainWindowViewModel), new PropertyMetadata(""));

        public static readonly DependencyProperty ProfileDirtyProperty =
            DependencyProperty.Register("ProfileDirty", typeof(bool), typeof(MainWindowViewModel), new PropertyMetadata(false));


        #endregion DependencyPropertyStaticBoylerplateCode

        private readonly IProfileRepository profileRepository;

        public MainWindowViewModel(IProfileRepository profileRepository)
        {
            this.profileRepository = profileRepository; 
        }


        public string ProfileName
        {
            get { return (string)GetValue(ProfileNameProperty); }
            set { SetValue(ProfileNameProperty, value); }
        }



        public bool ProfileDirty
        {
            get { return (bool)GetValue(ProfileDirtyProperty); }
            set { SetValue(ProfileDirtyProperty, value); }
        }


    }
}
