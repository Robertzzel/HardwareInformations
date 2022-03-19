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
        private static HardwareInfo _hardwareInfo = new HardwareInfo();

        public RAMMonitor()
        {
            _hardwareInfo.RefreshMemoryList();
        }

        public IEnumerable<ulong> GetCapacity()
        {
            return _hardwareInfo.MemoryList.Select(ramStick => ramStick.Capacity);
        }

        public IEnumerable<string> GetManufacturer()
        {
            return _hardwareInfo.MemoryList.Select(ramStick => ramStick.Manufacturer);
        }

        public IEnumerable<string> GetPartNumber()
        {
            return _hardwareInfo.MemoryList.Select(ramStick => ramStick.PartNumber);
        }

        public IEnumerable<uint> GetSpeed()
        {
            return _hardwareInfo.MemoryList.Select(ramStick => ramStick.Speed);
        }
    }

}