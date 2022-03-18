using Hardware.Info;
using HardwareInformation;

namespace Machine
{
    public class CPU
    {
        public string Manufacturer { get; set; } = String.Empty;
        public string Name { get; set; } = String.Empty;
        public string Arhitecture { get; set; } = String.Empty;
        public uint Family { get; set; } = default(uint);
        public uint NumberOfPhysicalCores { get; set; } = default(uint);
        public uint NumberOfLogicalCores { get; set; } = default(uint);
        public uint CurrentClockSpeed { get; set; } = default(uint);
        public string Description { get; set; } = String.Empty;
        public uint MaxClockSpeed { get; set; } = default(uint);
        public string SocketDesignation { get; set; } = String.Empty;
        public uint L2CacheSize { get; set; } = default(uint);
        public uint L3CacheSize { get; set; } = default(uint);
    }

    public interface ICPUMonitor
    {
        public IEnumerable<CPU> GetCPUs();
    }

    public class CPUMonitor : ICPUMonitor
    {
        private MachineInformation _machineInfo = MachineInformationGatherer.GatherInformation();
        private HardwareInfo _hardwareInfo = new HardwareInfo();

        public IEnumerable<CPU> GetCPUs()
        {
            List<CPU> cpus = new List<CPU>();
            _hardwareInfo.RefreshAll();

            for (int i = 0; i < _hardwareInfo.CpuList.Count(); i++)
            {
                cpus.Add
                (
                    new CPU
                    {
                        Manufacturer = _hardwareInfo.CpuList[i].Manufacturer,
                        Name = _hardwareInfo.CpuList[i].Name,
                        Arhitecture = _machineInfo.Cpu.Architecture,
                        Family = _machineInfo.Cpu.Family,
                        NumberOfPhysicalCores = _machineInfo.Cpu.PhysicalCores,
                        NumberOfLogicalCores = _machineInfo.Cpu.LogicalCores,
                        CurrentClockSpeed = _hardwareInfo.CpuList[i].CurrentClockSpeed,
                        Description = _hardwareInfo.CpuList[i].Description,
                        MaxClockSpeed = _hardwareInfo.CpuList[i].MaxClockSpeed,
                        SocketDesignation = _hardwareInfo.CpuList[i].SocketDesignation,
                        L2CacheSize = _hardwareInfo.CpuList[i].L2CacheSize,
                        L3CacheSize = _hardwareInfo.CpuList[i].L3CacheSize
                    }
                );
            }

            return cpus;
        }
    }
}