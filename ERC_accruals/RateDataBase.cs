using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERC_accruals
{
    public class RateDataBase
    {
        /// <summary>
        /// Тарифы
        /// </summary>
        public List<double> Rate { get; }

        /// <summary>
        /// Норматив
        /// </summary>
        public double AverageV { get; }
        /// <summary>
        /// Объем ХВС в предыдущем месяце
        /// </summary>
        public double VCVSprev { get; set; }
        /// <summary>
        /// Объем ГВС в предыдущем месяце
        /// </summary>
        public double VHVSprev { get; set; }
        /// <summary>
        /// Объем ЭЭ дневной в предыдущем месяце
        /// </summary>
        public double VEEDayprev { get; set; }
        /// <summary>
        /// Объем ЭЭ ночной в предыдущем месяце
        /// </summary>
        public double VEENightprev { get; set; }

       
    }

   
}
