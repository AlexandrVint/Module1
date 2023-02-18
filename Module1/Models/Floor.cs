using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Module1.ViewModels.Base;

namespace Module1.Models
{

    /// <summary>
    /// Класс этаж
    /// </summary>
    public class Floor: ViewModel
    {
        public int Id { get; set; }

        #region FloorCount : int - Количество этажей надземной части здания
        /// <summary>
        /// Количество этажей надземной части здания
        /// </summary>
        private int _FloorCount;

        public int FloorCount
        {
            get => _FloorCount;
            set => Set(ref _FloorCount, value);
        }
        #endregion

        #region FloorMark : double - отметка уровня пола этажей
        /// <summary>
        /// отметка уровня пола этажей
        /// </summary>
        private double _FloorMark;

        public double FloorMark
        {
            get => _FloorMark;
            set => Set(ref _FloorMark, value);
        }
        #endregion

        #region FloorMarkLevel2 : double - высотная отметка пола этажа второго этажа
        /// <summary>
        /// высотная отметка пола этажа второго этажа
        /// </summary>
        private double _FloorMarkLevel2;

        public double FloorMarkLevel2
        {
            get => _FloorMarkLevel2;
            set => Set(ref _FloorMarkLevel2, value);
        }
        #endregion

        #region IntakeHeight : double - высота воздухозабора относительно уровня земли
        /// <summary>
        /// высота воздухозабора относительно уровня земли
        /// </summary>
        private double _IntakeHeight;

        public double IntakeHeight
        {
            get => _IntakeHeight;
            set => Set(ref _IntakeHeight, value);
        }
        #endregion

        #region MainFloor : int - номер основного расченого этажа. Нижний этаж, на который приезжает лифтовая кабина
        /// <summary>
        /// номер основного расченого этажа. Нижний этаж, на который приезжает лифтовая кабина
        /// </summary>
        private int _MainFloor;

        public int MainFloor
        {
            get => _MainFloor;
            set => Set(ref _MainFloor, value);
        }
        #endregion

        #region FloorNumber : int - номер этажа
        private int _FloorNumber;
        /// <summary>
        /// номер этажа
        /// </summary>
        public int FloorNumber
        {
            get => _FloorNumber;
            set => Set(ref _FloorNumber, value);
        }
        #endregion
    }
}
