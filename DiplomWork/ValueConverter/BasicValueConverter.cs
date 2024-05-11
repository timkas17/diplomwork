using System.Windows.Data;
using System.Globalization;
using System.Windows.Markup;

namespace DiplomWork.ValueConverter
{
    /// <summary>
    /// Конвертер базовых значений, позволяющий напрямую использовать XAML
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public abstract class BasicValuseConverter<T> : MarkupExtension, IValueConverter
        where T : class, new ()
    {
        #region Приватные поля
        /// <summary>
        /// Единственный статический экземпляр конвертера значений
        /// </summary>
        private static T mConverter = null;
        #endregion

        #region Методы расширения разметки
        /// <summary>
        /// Получение статического экземпляра преобразователя значений
        /// </summary>
        /// <param name="serviceProvider">поставщик данных</param>
        /// <returns></returns>
        public override object ProvideValue(IServiceProvider serviceProvider)
        {
            return mConverter ?? (mConverter = new T());
        }
        #endregion

        #region Методы конвертирования значений
        /// <summary>
        /// Метод конфертации одного тип в другой
        /// </summary>
        /// <param name="value"></param>
        /// <param name="targetType"></param>
        /// <param name="parameter"></param>
        /// <param name="culture"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public abstract object Convert(object value, Type targetType, object parameter, CultureInfo culture);
        /// <summary>
        /// Метод для конвертирования к начальному значению
        /// </summary>
        /// <param name="value"></param>
        /// <param name="targetType"></param>
        /// <param name="parametr"></param>
        /// <param name="culture"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public abstract object ConvertBack(object value, Type targetType, object parametr, CultureInfo culture);
        #endregion
    }
}
