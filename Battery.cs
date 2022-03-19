using Hardware.Info;

namespace Machine
{
    public interface IBatteryMonitor
    {
        public string GetStatus();
        public int GetEstimatedChargeRemaining();
        public uint GetEstimatedRunTime();
    }

    public class BatteryMonitor : IBatteryMonitor
    {
        private HardwareInfo _hardwareInfo = new HardwareInfo();

        public int GetEstimatedChargeRemaining()
        {
            _hardwareInfo.RefreshBatteryList();
            return _hardwareInfo.BatteryList[0].EstimatedChargeRemaining;
        }

        public uint GetEstimatedRunTime()
        {
            _hardwareInfo.RefreshBatteryList();
            return _hardwareInfo.BatteryList[0].EstimatedRunTime;
        }

        public string GetStatus()
        {
            _hardwareInfo.RefreshBatteryList();
            return _hardwareInfo.BatteryList[0].BatteryStatusDescription;
        }
    }
}

