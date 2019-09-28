using CalcTrainer.Core.ViewModels;
using CalcTrainer.Core.Views;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Windows.Controls;
using System.Windows.Data;

namespace CalcTrainer.Core.wpfConverters
{
    public class ViewModelToViewConverter : IValueConverter 
    {
        private static readonly Dictionary<Type, Func<BaseViewModel, UserControl>> map = new Dictionary<Type, Func<BaseViewModel, UserControl>> 
        {
            { typeof(AvaitingViewModel), (val) => new AvaitingView(val)},
            { typeof(ProfileCrudViewModel), (val) => new ProfileCrudView()},
            { typeof(ProfileStatsViewModel), (val) => new ProfileStatsView(val)},
            { typeof(TrainingViewModel), (val) => new TrainingView()}
        };

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var type = value.GetType();

            if (map.TryGetValue(type, out var retFunc))
            {
                return retFunc((BaseViewModel) value);
            }
            Debugger.Break();
            return null;
            
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
