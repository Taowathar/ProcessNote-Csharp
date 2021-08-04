using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Data;

namespace ProcessNote.Converters
{
    [ValueConversion(typeof(int), typeof(string))]
    public class MemoryUsageConverter : IValueConverter
    {
        #region IValueConverter Members

        /// <summary>
        /// Converts a value. The data binding engine calls this method when it propagates a value from the binding source to the binding target.
        /// </summary>

        public object Convert(object value, Type targetType, object parameter,
                              System.Globalization.CultureInfo culture)
        {
            if (value is int)
            {
                decimal byteToMb = (int)value / 1024 / 1024;
                return Math.Round(byteToMb, 2).ToString() + " MB";
            }
            return string.Empty;
        }


        /// <summary>
        /// Converts a value. The data binding engine calls this method when it propagates a value from the binding target to the binding source.
        /// </summary>

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        #endregion
    }
}