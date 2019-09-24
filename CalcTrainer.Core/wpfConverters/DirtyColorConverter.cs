using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Media;

namespace CalcTrainer.Core.wpfConverters
{
    public class DirtyColorConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var bValue = (value as bool?) ?? false;

            if (bValue)
            {
                return Brushes.Red;
            }
            return Brushes.LightGray;

        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var cValue = value as Brush ?? Brushes.LightGray;

            return cValue == Brushes.Red;
                
            


        }
    }
}
