using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Module1.ViewModels.Base;

namespace Module1.Models
{
    /// <summary>
    /// Класс Лифтовой холл
    /// </summary>
    public  class ElevatorHall: ViewModel
    {

        #region DoorCountOnFloor : int - Свойство количество дверных проемов лифтового холла на этаже   
        /// <summary>
        /// Свойство количество дверных проемов лифтового холла на этаже
        /// </summary>
        public int DoorCountOnFloor { get; set; }
        #endregion

        #region HieghtDoorHall : double - Высота двери дверного холла на  этаже   
        /// <summary>
        /// Высота двери дверного холла на  этаже
        /// </summary>
        public double HieghtDoorHall { get; set; }
        #endregion

        #region WidthDoorHall : double - Ширина дверного проема лифтового холла на этаже   
        /// <summary>
        /// Ширина дверного проема лифтового холла на этаже
        /// </summary>
        public double WidthDoorHall { get; set; }
        #endregion

        #region DoorAreaHall : double - Площадь двери лифотового холла на  этаже   
        /// <summary>
        /// Площадь двери лифотового холла на  этаже
        /// </summary>
        public double DoorAreaHall { get; set; }
        #endregion

        #region HaveDoorOnFloorHall : bool - наличие дверей на этаже в лифтовой холле   
        /// <summary>
        /// наличие дверей на этаже в лифтовой холле
        /// </summary>
        public bool HaveDoorOnFloorHall { get; set; }
        #endregion

        public const double KMS_Hall=2.44;

    }
}
