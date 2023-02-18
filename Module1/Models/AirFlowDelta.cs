using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Module1.ViewModels.Base;

namespace Module1.Models
{
    public class AirFlowDelta:ViewModel
    {
        #region FlowDeltaDoorG : double - инфильтрация массового расхода воздуха через двери лифтовой шахты на жтаже
        private double _FlowDeltaDoorG;
        /// <summary>
        /// инфильтрация воздуха 
        /// </summary>
        public double FlowDeltaDoorG
        {
            get => _FlowDeltaDoorG;
            set => Set(ref _FlowDeltaDoorG, value);
        }
        #endregion

    }
}
