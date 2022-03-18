using Hardware.Info;
using HardwareInformation;

namespace Machine
{
    public class GPU
    {
        public string Caption { get; set; } = String.Empty;
        public uint BitsPerPixel { get; set; } = default(uint);
        public uint HorizontalResolution { get; set; } = default(uint);
        public uint VerticalResolution { get; set; } = default(uint);
        public uint RefreshRate { get; set; } = default(uint);
        public string Description { get; set; } = String.Empty;
        public string DriverVersion { get; set; } = String.Empty;
        public string Manufacturer { get; set; } = String.Empty;
        public uint MaxRefreshRate { get; set; } = default(uint);
        public uint MinRefreshRate { get; set; } = default(uint);
        public string Name { get; set; } = String.Empty; 
        public string VideoProcessor { get; set; } = String.Empty; 
        public ulong VRAM { get; set; } = default(ulong);
    }

    public interface IGPUMonitor
    {
        public IEnumerable<GPU> GetGPUs();
    }

    public class GPUMonitor: IGPUMonitor
    {
        private HardwareInfo _hardwareInfo = new HardwareInfo();
        private MachineInformation _machineInformation = MachineInformationGatherer.GatherInformation();

        public IEnumerable<GPU> GetGPUs()
        {
            List<GPU> gpus = new List<GPU>();
            _hardwareInfo.RefreshAll();

            for (int i = 0; i < _hardwareInfo.VideoControllerList.Count(); i++)
            {
                gpus.Add
                (
                    new GPU
                    {
                        Caption = _hardwareInfo.VideoControllerList[i].Caption,
                        BitsPerPixel = _hardwareInfo.VideoControllerList[i].CurrentBitsPerPixel,
                        HorizontalResolution = _hardwareInfo.VideoControllerList[i].CurrentHorizontalResolution,
                        VerticalResolution = _hardwareInfo.VideoControllerList[i].CurrentVerticalResolution,
                        RefreshRate = _hardwareInfo.VideoControllerList[i].CurrentRefreshRate,
                        Description = _hardwareInfo.VideoControllerList[i].Description,
                        DriverVersion = _hardwareInfo.VideoControllerList[i].DriverVersion,
                        Manufacturer = _hardwareInfo.VideoControllerList[i].Manufacturer,
                        MaxRefreshRate = _hardwareInfo.VideoControllerList[i].MaxRefreshRate,
                        MinRefreshRate = _hardwareInfo.VideoControllerList[i].MinRefreshRate,
                        Name = _hardwareInfo.VideoControllerList[i].Name,
                        VideoProcessor = _hardwareInfo.VideoControllerList[i].VideoProcessor,
                        VRAM = _machineInformation.Gpus[i].AvailableVideoMemory
                    }
                );
            }

            return gpus;
        }
    }
}