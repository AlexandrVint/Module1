using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Module1.ViewModels.Base;

namespace Module1.Models
{
    public class PressureFloorElevator:ViewModel
    {
        #region PresureFloor : double - давление в лифтовой шахте на этаже
        private double _PresureFloor;
        /// <summary>
        /// давление в лифтовой шахте на этаже
        /// </summary>
        public double PresureFloor
        {
            get => _PresureFloor;
            set => Set(ref _PresureFloor, value);
        }
        #endregion
    }
}
