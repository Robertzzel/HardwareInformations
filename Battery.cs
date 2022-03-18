using Hardware.Info;

namespace Machine
{
    public interface IBattery
    {
        public string Status { get; }
        public int EstimatedChargeRemaining { get; }
        public uint EstimatedRunTime { get; }
    }

    public class Battery : IBattery
    {
        private Hardware.Info.Battery _battery = new HardwareInfo().BatteryList[0];
        public string Status => _battery.BatteryStatus.ToString();
        public int EstimatedChargeRemaining => _battery.EstimatedChargeRemaining;
        public uint EstimatedRunTime => _battery.EstimatedRunTime;
    }
}

