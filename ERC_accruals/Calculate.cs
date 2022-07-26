using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERC_accruals
{
    public class Calculate 
    {
        private int _nPeople;        

        private Volumes _volumes;
        private Ratebase _ratebase;

        public void Init(Volumes volumes, Ratebase ratebase)
        {
            _volumes = volumes;
            _ratebase = ratebase;
        }
        public void SetPeopleNumber (int number)
        {
            _nPeople = number;
        }

        public double GetCVSSum()
        {
            if (_volumes.VolumeCVSCurrent != 0)
                return (_volumes.VolumeCVSCurrent - _volumes.VolumeCVSPrevious) * _ratebase.RateCVS;

            return _ratebase.NormativCVS * _nPeople * _ratebase.RateCVS; 
        }

        public double GetHVSSum()
        {
            if (_volumes.VolumeHVSCurrent != 0) 
                return (_volumes.VolumeHVSCurrent - _volumes.VolumeHVSPrevious) * _ratebase.RateHVS;
            
            return _ratebase.NormativHVS * _nPeople * _ratebase.RateHVS;
        }
        public double GetHVSEnergySum()
        {
            return GetHVSSum() * _ratebase.RateHVSEnergy;
        }

        public double GetEESum()
        {
            if (_volumes.VolumeEENightCurrent != 0)
                return ((_volumes.VolumeEEDayCurrent - _volumes.VolumeEEDayCurrent) * _ratebase.RateEEDay) +
                    ((_volumes.VolumeEENightCurrent - _volumes.VolumeEENightPrevious) * _ratebase.RateEENight);
            else return _ratebase.NormativEE * _nPeople * _ratebase.RateEE;
        }
        

        public double GetERCSum()
        {
            return GetCVSSum() + GetHVSSum() + GetHVSEnergySum() + GetEESum();
        }

    }
}
