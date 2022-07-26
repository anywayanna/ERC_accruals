
namespace ERC_accruals
{
    public class Volumes
    {
        private double _volumeCVSPrevious = 0;
        private double _volumeCVSCurrent = 0;

        private double _volumeHVSPrevious = 0;
        private double _volumeHVSCurrent = 0;

        private double _volumeEEDayPrevious = 0;
        private double _volumeEEDayCurrent = 0;

        private double _volumeEENightPrevious = 0;
        private double _volumeEENightCurrent = 0;

        public double VolumeCVSPrevious => _volumeCVSPrevious;
        public double VolumeCVSCurrent => _volumeCVSCurrent;

        public double VolumeHVSPrevious => _volumeHVSPrevious;
        public double VolumeHVSCurrent => _volumeHVSCurrent;

        public double VolumeEEDayPrevious => _volumeEEDayPrevious;
        public double VolumeEEDayCurrent => _volumeEEDayCurrent;

        public double VolumeEENightPrevious => _volumeEENightPrevious;
        public double VolumeEENightCurrent => _volumeEENightCurrent;

        public void Reset()
        {
            _volumeCVSCurrent = _volumeCVSPrevious;
            _volumeHVSCurrent = _volumeHVSPrevious;
            _volumeEEDayCurrent = _volumeEEDayPrevious;
            _volumeEENightCurrent = _volumeEENightPrevious;
        }
    
        public void Save()
        {
            _volumeCVSPrevious = _volumeCVSCurrent;
            _volumeHVSPrevious = _volumeHVSCurrent;
            _volumeEEDayPrevious = _volumeEEDayCurrent;
            _volumeEENightPrevious = _volumeEENightCurrent;
        }
        public void Save(string CVS, string HVS, string EEDay, string EENight)
        {
            _volumeCVSPrevious = _volumeCVSCurrent;
            _volumeHVSPrevious = _volumeHVSCurrent;
            _volumeEEDayPrevious = _volumeEEDayCurrent;
            _volumeEENightPrevious = _volumeEENightCurrent;

            _volumeCVSCurrent = double.Parse(CVS);
            _volumeHVSCurrent = double.Parse(HVS);
            _volumeEEDayCurrent = double.Parse(EEDay);
            _volumeEENightCurrent = double.Parse(EENight);
            
        }

    }
}
