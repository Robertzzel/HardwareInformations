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
        public int GetEstimatedChargeRemaining()
        {
            return HardwareInformations.HardwareInfo.BatteryList[0].EstimatedChargeRemaining;
        }

        public uint GetEstimatedRunTime()
        {
            return HardwareInformations.HardwareInfo.BatteryList[0].EstimatedRunTime;
        }

        public string GetStatus()
        {
            return HardwareInformations.HardwareInfo.BatteryList[0].BatteryStatusDescription;
        }
    }
}

