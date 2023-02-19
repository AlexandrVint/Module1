using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Module1.ViewModels.Base;

namespace Module1.Models
{
    public class AirFlow:ViewModel
    {
        

        #region FlowG : double - массовый расход воздуха на этаже   
        /// <summary>
        /// COMMENTS
        /// </summary>
        public double FlowG { get; set; }
        #endregion

        #region AirFlowL : double - объемный расход воздуха на этаже   
        /// <summary>
        /// объемный расход воздуха на этаже
        /// </summary>
        public double AirFlowL { get; set; }
        #endregion

        //
    }
}
