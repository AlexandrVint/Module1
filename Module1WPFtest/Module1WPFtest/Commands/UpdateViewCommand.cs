using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Module1WPFtest.ViewModels;

namespace Module1WPFtest.Commands
{
    public class UpdateViewCommand : ICommand
    {
        public MainViewModel viewModel;

        //конструктор 

        public UpdateViewCommand(MainViewModel viewModel)
        {
            this.viewModel = viewModel;
        }


        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            Console.WriteLine("test");
            if (parameter.ToString() == "Home")
            {
                viewModel.SelectViewModel = new HomeViewModel();
            }
            else if (parameter.ToString() == "Account")
            {
                viewModel.SelectViewModel = new AccountViewModel();
            }

        }

        public event EventHandler CanExecuteChanged;
    }
}
