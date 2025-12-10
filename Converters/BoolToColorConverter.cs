using System;
using Microsoft.Maui.Controls;

namespace TodoMauiMacApp.Converters
{
    public class BoolToColorConverter : IValueConverter
    {
        public Color TrueColor { get; set; } = Colors.LightGreen;
        public Color FalseColor { get; set; } = Colors.LightGray;

        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            if (value is bool b)
                return b ? TrueColor : FalseColor;
            return FalseColor;
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}