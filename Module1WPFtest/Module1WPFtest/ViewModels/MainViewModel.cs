using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Module1WPFtest.Commands;

namespace Module1WPFtest.ViewModels
{
    public class MainViewModel : BaseViewModel
    {
        #region SelecViewModel - выбор видовой модели

        private BaseViewModel _SelectViewModel;

        public BaseViewModel SelectViewModel
        {
            get { return _SelectViewModel; }
            set
            {
                _SelectViewModel = value; 
                OnPropertyChanged(nameof(SelectViewModel));
            }
        }


        #endregion

        #region Команды

        #region Команда - обновить представление

        public ICommand UpdateViewCommand { get; }

        public MainViewModel()
        {
            UpdateViewCommand = new UpdateViewCommand(this);
        }





        #endregion



        #endregion

    }
}
