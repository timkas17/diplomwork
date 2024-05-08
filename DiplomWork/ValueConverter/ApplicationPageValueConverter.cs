using System;
using System.Globalization;
using System.Windows;
using System.Diagnostics;
using DiplomWork.Pages;
using System.Net.Http.Headers;

namespace DiplomWork.ValueConverter
{
    /// <summary>
    /// Класс конвертирует <see cref="ApplicationPage"/> в актуальную страницу/представление
    /// </summary>
    public class ApplicationPageValueConverter : BasicValuseConverter<ApplicationPageValueConverter>
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            //Нахождение соответствующей страницы
            switch ((ApplicationPage)value)
            {
                case ApplicationPage.Login:
                    return new LoginPage();

                default:
                    Debugger.Break();
                    return null;
            }
        }
        public object ConvertBack(object value, Type targetType, object parametr, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
