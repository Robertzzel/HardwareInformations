using Hardware.Info;
using HardwareInformation;

namespace Machine
{
    public interface ICPUMonitor
    {
        public string GetManufacturer();
        public string GetName();
        public string GetArhitecture();
        public uint GetFamily();
        public uint GetNumberOfPhysicalCores();
        public uint GetNumberOfLogicalCores();
        public uint GetCurrentClockSpeed();
        public string GetDescription();
        public uint GetMaxClockSpeed();
        public string GetSocketDesignation();
        public uint GetL2CacheSize();
        public uint GetL3CacheSize();
    }

    public class CPUMonitor : ICPUMonitor
    {
        private static MachineInformation _machineInfo = MachineInformationGatherer.GatherInformation();
        private static HardwareInfo _hardwareInfo = new HardwareInfo();

        public string GetManufacturer() => _machineInfo.Cpu.Vendor;
        public string GetName() => _machineInfo.Cpu.Name;
        public string GetArhitecture() => _machineInfo.Cpu.Architecture;
        public uint GetFamily() => _machineInfo.Cpu.Family;
        public uint GetNumberOfPhysicalCores() => _machineInfo.Cpu.PhysicalCores;
        public uint GetNumberOfLogicalCores() => _machineInfo.Cpu.LogicalCores;
        public uint GetCurrentClockSpeed()
        {
            _hardwareInfo.RefreshCPUList();
            return _hardwareInfo.CpuList[0].CurrentClockSpeed;
        }
        public string GetDescription() => _machineInfo.Cpu.Caption;
        public uint GetMaxClockSpeed()
        {
            _hardwareInfo.RefreshCPUList();
            return _hardwareInfo.CpuList[0].MaxClockSpeed;
        }
        
        public string GetSocketDesignation() => _machineInfo.Cpu.Socket;
        public uint GetL2CacheSize()
        {
            _hardwareInfo.RefreshCPUList();
            return _hardwareInfo.CpuList[0].L2CacheSize;
        }
        public uint GetL3CacheSize()
        {
            _hardwareInfo.RefreshCPUList();
            return _hardwareInfo.CpuList[0].L3CacheSize;
        }

}
}