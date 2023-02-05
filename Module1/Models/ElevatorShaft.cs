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
        public int Id { get; set; }

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

        #region HeightDoorCabin : double - высота двери кабины лифта на основном этаже

        /// <summary>
        /// Свойство Высота двери лифтовой шахты
        /// </summary>

        private double _HeightDoorCabin;

        public double HeightDoorCabin
        {
            get => _HeightDoorCabin;

            set => Set(ref _HeightDoorCabin, value);
        }

        #endregion

        #region WishtDoorCabin : double - ширина дверного проема лифтовой шахты на основном этаже

        /// <summary>
        /// Свойство ширина дверного проема лифтовой шахты
        /// </summary>
        private double _WidhtDoorCabin;

        public double WishtDoorCabin
        {
            get => _WidhtDoorCabin;
            set => Set(ref _WidhtDoorCabin, value);

        }

        #endregion

        #region DoorAreaCabin : double - площадь дверного проема лифтовой шахты на основном этаже

        /// <summary>
        /// Свойство площадь дверного проема лифтовой шахты
        /// </summary>

        private double _DoorAreaCabin;

        public double DoorAreaCabin
        {
            get => _DoorAreaCabin;
            set => Set(ref _DoorAreaCabin, value);
        }

        #endregion

        #region AreaCabin : double - площадь поперечного сечения кабины лифта

        /// <summary>
        /// Свойство площадь поперечного сечения кабины лифта
        /// </summary>

        private double _AreaCabin;

        public double AreaCabin
        {
            get => _AreaCabin;
            set => Set(ref _AreaCabin, value);
        }


        #endregion

        #region HaveDoorOnFlooShaft : bool - Наличие двеи в лифтовой шахте на основном этаже
        /// <summary>
        /// Наличие двеи в лифтовой шахте на основном этаже
        /// </summary>
        private bool _HaveDoorOnFlooShaft;

        public bool HaveDoorOnFlooShaft
        {
            get => _HaveDoorOnFlooShaft;
            set => Set(ref _HaveDoorOnFlooShaft, value);
        }
        #endregion

        #region AreaShaft : double - Площадь поперечного сечения шахты лифта
        /// <summary>
        /// Площадь поперечного сечения шахты лифта
        /// </summary>
        private double _AreaShaft;

        public double AreaShaft
        {
            get => _AreaShaft;
            set => Set(ref _AreaShaft, value);
        }
        #endregion

        #region KMSshaft : double - Коэффициент местного сопротивления (КМС) шахты лифта
        /// <summary>
        /// Коэффициент местного сопротивления (КМС) шахты лифта
        /// </summary>
        private double _KMSshaft;

        public double KMSshaft
        {
            get => _KMSshaft;
            set => Set(ref _KMSshaft, value);
        }
        #endregion


    }
}
