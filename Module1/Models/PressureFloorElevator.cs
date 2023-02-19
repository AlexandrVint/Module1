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
        /// <summary>
        /// COMMENTS
        /// </summary>
        public double PresureFloor { get; set; }
        #endregion
    }
}
