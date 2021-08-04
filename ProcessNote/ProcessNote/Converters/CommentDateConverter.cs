using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace ProcessNote.Converters
{
    [ValueConversion(typeof(DateTime), typeof(string))]
    public class CommentDateConverter : IValueConverter
    {
        #region IValueConverter Members

        /// <summary>
        /// Converts a value. The data binding engine calls this method when it propagates a value from the binding source to the binding target.
        /// </summary>

        public object Convert(object value, Type targetType, object parameter,
                              System.Globalization.CultureInfo culture)
        {
            if (value is DateTime)
            {
                DateTime test = (DateTime)value;
                string date = test.ToString("dd/MM/yy HH:mm");
                return date;
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
