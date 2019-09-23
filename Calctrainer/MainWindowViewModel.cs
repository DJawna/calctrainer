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


        #endregion DependencyPropertyStaticBoylerplateCode


        public string ProfileName
        {
            get { return (string)GetValue(ProfileNameProperty); }
            set { SetValue(ProfileNameProperty, value); }
        }

        
        

    }
}
