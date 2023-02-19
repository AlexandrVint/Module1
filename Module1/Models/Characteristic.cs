using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Module1.ViewModels.Base;

namespace Module1.Models
{
    public class Characteristic:ViewModel
    {
        

        #region CharacteristicElevator : double - характеристика сопротивления шахты   
        /// <summary>
        /// характеристика сопротивления шахты
        /// </summary>
        public double CharacteristicElevator { get; set; }
        #endregion

        #region CharacteristicElevatorHall : double - характеристика сопротивления лифтового холла   
        /// <summary>
        /// характеристика сопротивления лифтового холла
        /// </summary>
        public double CharacteristicElevatorHall { get; set; }
        #endregion

        #region SumCharacteristic : double - суммарная (совместная) характеристика дифтового холла и шахты   
        /// <summary>
        /// суммарная (совместная) характеристика дифтового холла и шахты
        /// </summary>
        public double SumCharacteristic { get; set; }
        #endregion


    }
}
