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
    [ValueConversion(typeof(string), typeof(string))]
    public class CpuUsageConverter : IValueConverter
    {
        #region IValueConverter Members

        /// <summary>
        /// Converts a value. The data binding engine calls this method when it propagates a value from the binding source to the binding target.
        /// </summary>

        public object Convert(object value, Type targetType, object parameter,
                              System.Globalization.CultureInfo culture)
        {
            if (value is string)
            {
                PerformanceCounter process_cpu = new PerformanceCounter("Process", "% Processor Time",value.ToString());

                process_cpu.NextValue();

                var result = Math.Round(process_cpu.NextValue() / Environment.ProcessorCount, 2);

                return result.ToString() + "%";
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
