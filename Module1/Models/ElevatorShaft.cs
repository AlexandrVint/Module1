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
        /// количество кабин в лифтовой шахте
        /// </summary>
        public int CabinCount { get; set; }
        #endregion

        #region HeightDoorCabin : double - высота двери кабины лифта на этаже   
        /// <summary>
        /// высота двери кабины лифта на этаже
        /// </summary>
        public double HeightDoorCabin { get; set; }
        #endregion

        #region WishtDoorCabin : double - ширина дверного проема лифтовой шахты на этаже   
        /// <summary>
        /// ширина дверного проема лифтовой шахты на этаже
        /// </summary>
        public double WishtDoorCabin { get; set; }
        #endregion

        #region DoorAreaCabin : double - площадь дверного проема лифтовой шахты на этаже   
        /// <summary>
        /// площадь дверного проема лифтовой шахты на этаже
        /// </summary>
        public double DoorAreaCabin { get; set; }
        #endregion

        #region AreaCabin : double - площадь поперечного сечения кабины лифта   
        /// <summary>
        /// площадь поперечного сечения кабины лифта
        /// </summary>
        public double AreaCabin { get; set; }
        #endregion

        #region HaveDoorOnFlooShaft : bool - Наличие двеи в лифтовой шахте на основном этаже   
        /// <summary>
        /// Наличие двеи в лифтовой шахте на основном этаже
        /// </summary>
        public bool HaveDoorOnFlooShaft { get; set; }
        #endregion

        #region AreaShaft : double - Площадь поперечного сечения шахты лифта   
        /// <summary>
        /// Площадь поперечного сечения шахты лифта
        /// </summary>
        public double AreaShaft { get; set; }
        #endregion

        #region KMSshaft : double - Коэффициент местного сопротивления (КМС) шахты лифта   
        /// <summary>
        /// Коэффициент местного сопротивления (КМС) шахты лифта
        /// </summary>
        public double KMSshaft { get; set; }
        #endregion


    }
}
