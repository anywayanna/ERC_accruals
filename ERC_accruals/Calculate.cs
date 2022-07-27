
namespace ERC_accruals
{
    public class Calculate 
    {
        private int _nPeople;        

        private Volumes _volumes;
        private Ratebase _ratebase;

        private double _CVSResult;
        private double _HVSResult;
        private double _HVSEnergyResult;
        private double _EEResult;

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
            {
                _CVSResult = (_volumes.VolumeCVSCurrent - _volumes.VolumeCVSPrevious) * _ratebase.RateCVS;
                return _CVSResult;
            }
            _CVSResult = _ratebase.NormativCVS * _nPeople * _ratebase.RateCVS; 
            return _CVSResult;
        }

        public double GetHVSSum()
        {
            if (_volumes.VolumeHVSCurrent != 0)
            {
                _HVSResult = (_volumes.VolumeHVSCurrent - _volumes.VolumeHVSPrevious) * _ratebase.RateHVS;
                return _HVSResult;
            }
            _HVSResult= _ratebase.NormativHVS * _nPeople * _ratebase.RateHVS;
            return _HVSResult;
        }
        public double GetHVSEnergySum()
        {
            if (_volumes.VolumeHVSCurrent !=0)
            {
                _HVSEnergyResult = (_volumes.VolumeHVSCurrent-_volumes.VolumeHVSPrevious) * _ratebase.NormativHVSEnergy * _ratebase.RateHVSEnergy;
                return _HVSEnergyResult;
            }
            _HVSEnergyResult = _ratebase.NormativHVSEnergy * _ratebase.RateHVSEnergy * _ratebase.NormativHVS;
            return _HVSEnergyResult;
        }

        public double GetEESum()
        {
            if (_volumes.VolumeEENightCurrent != 0)
            {
                _EEResult = ((_volumes.VolumeEEDayCurrent - _volumes.VolumeEEDayPrevious) * _ratebase.RateEEDay) +
                    ((_volumes.VolumeEENightCurrent - _volumes.VolumeEENightPrevious) * _ratebase.RateEENight);
                return _EEResult;
            }
            _EEResult = _ratebase.NormativEE * _nPeople * _ratebase.RateEE;
            return _EEResult;
        }

        public double GetERCSum()
        {
            return _CVSResult + _HVSResult + _HVSEnergyResult + _EEResult;
        }
    }
}
