using System;
using System.Globalization;
using System.Windows.Data;

namespace ExcursionsManagementApp.UI.Views
{
    /// <summary>
    /// To pass data from multiple fields
    /// </summary>
    public class MultiValueConverter : IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            try
            {
                return new Tuple<string, string>(values[0].ToString(), values[1].ToString());
            }
            catch (NullReferenceException)
            {
                return new Tuple<string, string>(string.Empty, string.Empty);
            }
            
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
