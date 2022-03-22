using Hardware.Info;
using HardwareInformation;

namespace Machine
{
    public interface IRAMMonitor
    {
        public IEnumerable<uint> GetSpeed();
        public IEnumerable<string> GetManufacturer();
        public IEnumerable<ulong> GetCapacity();
        public IEnumerable<string> GetPartNumber();
    }

    public class RAMMonitor : IRAMMonitor
    {
        public IEnumerable<ulong> GetCapacity()
        {
            return HardwareInformations.HardwareInfo.MemoryList.Select(ramStick => ramStick.Capacity);
        }

        public IEnumerable<string> GetManufacturer()
        {
            return HardwareInformations.HardwareInfo.MemoryList.Select(ramStick => ramStick.Manufacturer);
        }

        public IEnumerable<string> GetPartNumber()
        {
            return HardwareInformations.HardwareInfo.MemoryList.Select(ramStick => ramStick.PartNumber);
        }

        public IEnumerable<uint> GetSpeed()
        {
            return HardwareInformations.HardwareInfo.MemoryList.Select(ramStick => ramStick.Speed);
        }
    }

}