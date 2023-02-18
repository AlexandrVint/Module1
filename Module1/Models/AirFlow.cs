using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Module1.ViewModels.Base;

namespace Module1.Models
{
    public class AirFlow:ViewModel
    {
        #region FlowG : double - массовый расход воздуха на этаже
        private double _FlowG;
        /// <summary>
        /// массовый расход воздуха на этаже
        /// </summary>
        public double FlowG
        {
            get => _FlowG;
            set => Set(ref _FlowG, value);
        }
        #endregion

        #region AirFlowL : double - объемный расход воздуха на этаже
        private double _AirFlowL;
        /// <summary>
        /// объемный расход воздуха на этаже
        /// </summary>
        public double AirFlowL
        {
            get => _AirFlowL;
            set => Set(ref _AirFlowL, value);
        }
        #endregion

    }
}
