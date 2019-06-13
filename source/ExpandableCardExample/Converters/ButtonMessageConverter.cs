using System;
using System.Globalization;
using Xamarin.Forms;

namespace ExpandableCardExample
{
    public class ButtonMessageConverter : IValueConverter
    {
        public ButtonMessageConverter()
        {
        }

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture) =>
            (value is bool status && status) ? "Hide notification" : "Show notification";

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
