using Hardware.Info;
using HardwareInformation;

namespace Machine
{
    public class RAM
    {
        public uint Speed { get; set; } = default(uint);
        public string Manufacturer { get; set; } = String.Empty;
        public ulong Capacity { get; set; } = default(ulong);
        public string PartNumber { get; set; } = String.Empty;
    }

    public interface IRAMMonitor
    {
        public IEnumerable<RAM> GetRAMSticks();
    }

    public class RAMMonitor : IRAMMonitor
    {
        private HardwareInfo _hardwareInfo = new HardwareInfo();

        public IEnumerable<RAM> GetRAMSticks()
        {
            List<RAM> ramSticks = new List<RAM>();
            _hardwareInfo.RefreshAll();

            foreach (var memory in _hardwareInfo.MemoryList)
            {
                ramSticks.Add
                (
                    new RAM
                    {
                        Speed = memory.Speed,
                        Manufacturer = memory.Manufacturer,
                        Capacity = memory.Capacity,
                        PartNumber = memory.PartNumber,
                    }
                );
            }

            return ramSticks;
        }
    }

}