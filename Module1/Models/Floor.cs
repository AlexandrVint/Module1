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
        public int FloorCount { get; set; }
        #endregion

        #region FloorMark : double - отметка уровня пола этажей   
        /// <summary>
        /// отметка уровня пола этажей
        /// </summary>
        public double FloorMark { get; set; }
        #endregion

        #region FloorMarkLevel2 : double - высотная отметка пола этажа второго этажа   
        /// <summary>
        /// высотная отметка пола этажа второго этажа
        /// </summary>
        public double FloorMarkLevel2 { get; set; }
        #endregion

        #region IntakeHeight : double - высота воздухозабора относительно уровня земли   
        /// <summary>
        /// высота воздухозабора относительно уровня земли
        /// </summary>
        public double IntakeHeight { get; set; }
        #endregion

        #region MainFloor : int - номер основного расченого этажа. Нижний этаж, на который приезжает лифтовая кабина   
        /// <summary>
        /// номер основного расченого этажа. Нижний этаж, на который приезжает лифтовая кабина
        /// </summary>
        public int MainFloor { get; set; }
        #endregion

        #region FloorNumber : int - номер этажа   
        /// <summary>
        /// номер этажа
        /// </summary>
        public int FloorNumber { get; set; }
        #endregion
    }
}
