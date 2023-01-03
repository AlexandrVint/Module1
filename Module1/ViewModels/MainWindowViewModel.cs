using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Markup;
using Module1.ViewModels.Base;

namespace Module1.ViewModels
{
    [MarkupExtensionReturnType(typeof(MainWindowViewModel))]
    internal class MainWindowViewModel : ViewModel
    {
        

        #region Заголовок окна

        private string _Title = "Расчет подпора воздуха в лифтовую шахту";

        public string Title
        {
            get => _Title;

            set => Set(ref _Title, value);
        }


        #endregion

        #region Статус программы



        #endregion

        #region Конманды



        #endregion

        #region Свойства



        #endregion

        #region Конструктор MainViewModel



        #endregion

    }
}
