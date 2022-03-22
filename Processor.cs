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
        public string GetManufacturer() => HardwareInformations.MachineInfo.Cpu.Vendor;
        public string GetName() => HardwareInformations.MachineInfo.Cpu.Name;
        public string GetArhitecture() => HardwareInformations.MachineInfo.Cpu.Architecture;
        public uint GetFamily() => HardwareInformations.MachineInfo.Cpu.Family;
        public uint GetNumberOfPhysicalCores() => HardwareInformations.MachineInfo.Cpu.PhysicalCores;
        public uint GetNumberOfLogicalCores() => HardwareInformations.MachineInfo.Cpu.LogicalCores;
        public uint GetCurrentClockSpeed() => HardwareInformations.HardwareInfo.CpuList[0].CurrentClockSpeed;
        public string GetDescription() => HardwareInformations.MachineInfo.Cpu.Caption;
        public uint GetMaxClockSpeed() => HardwareInformations.HardwareInfo.CpuList[0].MaxClockSpeed;
        public string GetSocketDesignation() => HardwareInformations.MachineInfo.Cpu.Socket;
        public uint GetL2CacheSize() => HardwareInformations.HardwareInfo.CpuList[0].L2CacheSize;
        public uint GetL3CacheSize() => HardwareInformations.HardwareInfo.CpuList[0].L3CacheSize;

}
}