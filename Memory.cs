using Hardware.Info;
using HardwareInformation;

namespace Machine
{
    public interface IRAM
    {
        public uint Speed { get; }
        public string Manufacturer { get; }
        public ulong Capacity { get; }
        public string PartNumber { get; }
    }

    public class RAM : IRAM
    {
        private Memory _memory = new HardwareInfo().MemoryList[0];
        private MachineInformation _machineInformation = MachineInformationGatherer.GatherInformation();
        public uint Speed => _memory.Speed;
        public string Manufacturer => _memory.Manufacturer;
        public ulong Capacity => _memory.Capacity;
        public string PartNumber => _machineInformation.RAMSticks[0].PartNumber;
    }
}