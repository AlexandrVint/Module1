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
        private double _CharacteristicElevator;
        /// <summary>
        /// характеристика сопротивления шахты
        /// </summary>
        public double CharacteristicElevator
        {
            get => _CharacteristicElevator;
            set => Set(ref _CharacteristicElevator, value);
        }
        #endregion


        #region CharacteristicElevatorHall : double - характеристика сопротивления лифтового холла
        private double _CharacteristicElevatorHall;
        /// <summary>
        /// характеристика сопротивления лифтового холла
        /// </summary>
        public double CharacteristicElevatorHall
        {
            get => _CharacteristicElevatorHall;
            set => Set(ref _CharacteristicElevatorHall, value);
        }
        #endregion

        #region SumCharacteristic : double - суммарная (совместная) характеристика дифтового холла и шахты
        private double _SumCharacteristic;
        /// <summary>
        /// суммарная (совместная) характеристика дифтового холла и шахты
        /// </summary>
        public double SumCharacteristic
        {
            get => _SumCharacteristic;
            set => Set(ref _SumCharacteristic, value);
        }
        #endregion
    }
}
