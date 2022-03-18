using Hardware.Info;

namespace Machine
{
    public class Battery
    {
        public string Status { get; set; } = String.Empty;
        public int EstimatedChargeRemaining { get; set; } = default(int);
        public uint EstimatedRunTime { get; set; } = default(uint);
    }

    public interface IBatteryMonitor
    {
        public IEnumerable<Battery> GetBatterys();
    }

    public class BatteryMonitor : IBatteryMonitor
    {
        private HardwareInfo _hardwareInfo = new HardwareInfo();

        public IEnumerable<Battery> GetBatterys()
        {
            List<Battery> batterys = new List<Battery>();
            _hardwareInfo.RefreshAll();

            foreach (var battery in _hardwareInfo.BatteryList)
            {
                batterys.Add
                (
                    new Battery
                    {
                        Status = battery.BatteryStatusDescription,
                        EstimatedChargeRemaining = battery.EstimatedChargeRemaining,
                        EstimatedRunTime = battery.EstimatedRunTime,

                    }
                );
            }

            return batterys;
        }
    }
}

