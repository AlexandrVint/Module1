using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Module1.ViewModels.Base;

namespace Module1.Models
{
    /// <summary>
    /// Класс лифтовая шахта
    /// </summary>
    public class ElevatorShaft:ViewModel
    {
        #region CabinCount : int - количество кабин в лифтовой шахте

        /// <summary>
        /// Свойство Количество кабин в лифтовой шахте 
        /// </summary>

        private int _CabinCount;

        public int CabinCount
        {
            get => _CabinCount;
            set => Set(ref _CabinCount, value);
        }

        #endregion

        #region HeightDoorCabin : double - высота двери кабины лифта 

        /// <summary>
        /// Свойство Высота двери кабины лифта 
        /// </summary>

        private double _HeightDoorCabin;

        public double HeightDoorCabin
        {
            get => _HeightDoorCabin;

            set => Set(ref _HeightDoorCabin, value);
        }

        #endregion




    }
}
