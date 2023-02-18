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

        #region DoorCountOnFloor : int - количество дверных проемов лифтового холла на на основном этаже

        /// <summary>
        /// Свойство количество дверных проемов лифтового холла на этаже
        /// </summary>
        private int _DoorCountOnFloor;

        public int DoorCountOnFloor
        {
            get => _DoorCountOnFloor;
            set => Set(ref _DoorCountOnFloor, value);
        }
        #endregion

        #region HieghtDoorHall : double - Высота двери дверного холла на  этаже
        /// <summary>
        /// Высота двери дверного холла
        /// </summary>
        private double _HieghtDoorHall;

        public double HieghtDoorHall
        {
            get => _HieghtDoorHall;
            set => Set(ref _HieghtDoorHall, value);
        }
        #endregion

        #region WidthDoorHall : double - Ширина дверного проема лифтового холла на этаже
        /// <summary>
        /// Ширина дверного проема лифтового холла
        /// </summary>
        private double _WidthDoorHall;

        public double WidthDoorHall
        {
            get => _WidthDoorHall;
            set => Set(ref _WidthDoorHall, value);
        }
        #endregion

        #region DoorAreaHall : double - Площадь двери лифотового холла на  этаже
        /// <summary>
        /// Площадь двери лифотового холла на основном этаже
        /// </summary>
        private double _DoorAreaHall;

        public double DoorAreaHall
        {
            get => _DoorAreaHall;
            set => Set(ref _DoorAreaHall, value);
        }
        #endregion

        #region HaveDoorOnFloorHall : bool - наличие дверей на этаже в лифтовой холле
        /// <summary>
        /// наличие дверей на основном этаже в лифтовом холле
        /// </summary>
        private bool _HaveDoorOnFloorHall;

        public bool HaveDoorOnFloorHall
        {
            get => _HaveDoorOnFloorHall;
            set => Set(ref _HaveDoorOnFloorHall, value);
        }
        #endregion

        public const double KMS_Hall=2.44;

    }
}
