using Hardware.Info;
using HardwareInformation;

namespace Machine
{
    public interface ICPU
    {
        public string Manufacturer { get; }
        public string Name { get; }
        public string Arhitecture { get; }
        public uint Family { get; }
        public uint NumberOfPhysicalCores { get; }
        public uint NumberOfLogicalCores { get; }
        public uint CurrentClockSpeed { get; }
        public string Description { get; }
        public uint MaxClockSpeed { get; }
        public string SocketDesignation { get; }
        public uint L2CacheSize { get; }
        public uint L3CacheSize { get; }
    }

    public class CPU : ICPU
    {
        private MachineInformation _machineInfo = MachineInformationGatherer.GatherInformation();
        private HardwareInfo _hardwareInfo = new HardwareInfo();
        public string Manufacturer => _hardwareInfo.MotherboardList[0].Manufacturer;

        public string Name => _hardwareInfo.MotherboardList[0].Product;

        public string Arhitecture => _machineInfo.Cpu.Architecture;

        public uint Family => _machineInfo.Cpu.Family;

        public uint NumberOfPhysicalCores => _machineInfo.Cpu.PhysicalCores;

        public uint NumberOfLogicalCores => _machineInfo.Cpu.LogicalCores;

        public uint CurrentClockSpeed => _hardwareInfo.CpuList[0].CurrentClockSpeed;

        public string Description => _hardwareInfo.CpuList[0].Description;

        public uint MaxClockSpeed => _hardwareInfo.CpuList[0].MaxClockSpeed;

        public string SocketDesignation => _hardwareInfo.CpuList[0].SocketDesignation;

        public uint L2CacheSize => _hardwareInfo.CpuList[0].L2CacheSize;

        public uint L3CacheSize => _hardwareInfo.CpuList[0].L3CacheSize;
    }
}