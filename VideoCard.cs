using Hardware.Info;
using HardwareInformation;

namespace Machine
{
    public interface IGPU
    {
        public string Caption { get; }
        public uint BitsPerPixel { get; }
        public uint HorizontalResolution { get; }
        public uint VerticalResolution { get; }
        public uint RefreshRate { get; }
        public string Description { get; }
        public string DriverVersion { get; }
        public string Manufacturer { get; }
        public uint MaxRefreshRate { get; }
        public uint MinRefreshRate { get; }
        public string Name { get; }
        public string VideoProcessor { get; }
        public ulong VRAM { get; }
    }

    public class GPU : IGPU
    {
        private HardwareInfo _hardwareInfo = new HardwareInfo();
        private MachineInformation _machineInformation = MachineInformationGatherer.GatherInformation();
        public string Caption => _hardwareInfo.VideoControllerList[0].Caption;

        public uint BitsPerPixel => _hardwareInfo.VideoControllerList[0].CurrentBitsPerPixel;

        public uint HorizontalResolution => _hardwareInfo.VideoControllerList[0].CurrentHorizontalResolution;

        public uint VerticalResolution => _hardwareInfo.VideoControllerList[0].CurrentVerticalResolution;

        public uint RefreshRate => _hardwareInfo.VideoControllerList[0].CurrentRefreshRate;

        public string Description => _hardwareInfo.VideoControllerList[0].Description;

        public string DriverVersion => _hardwareInfo.VideoControllerList[0].DriverVersion;

        public string Manufacturer => _hardwareInfo.VideoControllerList[0].Manufacturer;

        public uint MaxRefreshRate => _hardwareInfo.VideoControllerList[0].MaxRefreshRate;

        public uint MinRefreshRate => _hardwareInfo.VideoControllerList[0].MinRefreshRate;

        public string Name => _hardwareInfo.VideoControllerList[0].Name;

        public string VideoProcessor => _hardwareInfo.VideoControllerList[0].VideoProcessor;

        public ulong VRAM => _machineInformation.Gpus[0].AvailableVideoMemory;
    }
}