using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERC_accruals
{
    public class Ratebase
    {
        private const double _normativCVS = 4.85;
        private const double _rateCVS = 35.78;

        private const double _normativHVS = 4.01;
        private const double _rateHVS = 35.78;

        private const double _normativHVSEnergy = 0.05349;
        private const double _rateHVSEnergy = 998.69;

        private const double _normativEE = 164;
        private const double _rateEE = 4.28;

        private const double _rateEEDay = 4.9;

        private const double _rateEENight = 2.31;

        public double NormativCVS => _normativCVS;
        public double RateCVS => _rateCVS;

        public double NormativHVS => _normativHVS;
        public double RateHVS => _rateHVS;

        public double NormativHVSEnergy => _normativHVSEnergy;
        public double RateHVSEnergy => _rateHVSEnergy;

        public double NormativEE => _normativEE;
        public double RateEE => _rateEE;

        public double RateEEDay => _rateEEDay;

        public double RateEENight => _rateEENight;

    }
}
