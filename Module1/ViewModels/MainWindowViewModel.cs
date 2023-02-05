using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Input;
using System.Windows.Markup;
using System.Xaml;
using Module1.Infrastructure.Commands;
using Module1.ViewModels.Base;
using Module1.Views.Window;

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

        #region CloseApplicationCommand - команда закрыть приложение

        public ICommand CloseApplicationCommand { get; }

        private void OnCloseApplicationCommand(object p)
        {
            Application.Current.Shutdown();
        }

        private bool CanCloseApplicationCommand(object p)
        {
            return true;
        }

        #endregion

        

       

        #endregion

        #region Свойства



        #endregion

        #region Конструктор MainViewModel

        public MainWindowViewModel()
        {
            CloseApplicationCommand = new LambdaCommand(OnCloseApplicationCommand, CanCloseApplicationCommand);
            
        }


        #endregion

    }
}
