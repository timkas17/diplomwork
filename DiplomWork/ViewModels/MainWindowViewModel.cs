using DiplomWork;
using DiplomWork.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiplomWork.ViewModels
{
    internal class MainWindowViewModel : ViewModel
    {
        #region Заголовок окна
        private string _Title = "Диплом";

        /// <summary>
        /// Заголовок окна
        /// </summary>
        public string Title
        {
            get => _Title;
            set => Set(ref _Title, value);
        }
        #endregion

        #region Текущая страница приложения
        /// <summary>
        /// Текущая страница приложения
        /// </summary>
        public ApplicationPage CurrentPage { get; set; } = ApplicationPage.Login;
        #endregion
    }
}
