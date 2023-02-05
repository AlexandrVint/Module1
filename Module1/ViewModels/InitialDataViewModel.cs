using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Module1.DataBase;
using Module1.ViewModels.Base;

namespace Module1.ViewModels
{
   public class InitialDataViewModel: ViewModel
    {
        public ICommand StarTableFloorWindow { get; }

        private void OnStarTableFloorWindow(object p)
        {

        }

        private bool CanStarTableFloorWindow(object p)
        {
            return true;
        }

    }
}
