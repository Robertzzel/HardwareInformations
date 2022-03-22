using Machine;

namespace Machine
{
    public interface IGPUMonitor
    {
        public IEnumerable<string> GetCaption();
        public IEnumerable<uint> GetBitsPerPixel();
        public IEnumerable<uint> GetHorizontalResolution();
        public IEnumerable<uint> GetVerticalResolution();
        public IEnumerable<uint> GetRefreshRate();
        public IEnumerable<string> GetDescription();
        public IEnumerable<string> GetDriverVersion();
        public IEnumerable<string> GetManufacturer();
        public IEnumerable<uint> GetMaxRefreshRate();
        public IEnumerable<uint> GetMinRefreshRate();
        public IEnumerable<string> GetName();
        public IEnumerable<string> GetVideoProcessor();
        public IEnumerable<ulong> GetVRAM();
    }

    public class GPUMonitor: IGPUMonitor
    {
        public GPUMonitor()
        {
            HardwareInformations.HardwareInfo.RefreshNetworkAdapterList();
        }

        public IEnumerable<uint> GetBitsPerPixel()
        {
            return HardwareInformations.HardwareInfo.VideoControllerList.Select(vc => vc.CurrentBitsPerPixel);
        }

        public IEnumerable<string> GetCaption()
        {
            return HardwareInformations.HardwareInfo.VideoControllerList.Select(vc => vc.Caption);
        }

        public IEnumerable<string> GetDescription()
        {
            return HardwareInformations.HardwareInfo.VideoControllerList.Select(vc => vc.Description);
        }

        public IEnumerable<string> GetDriverVersion()
        {
            return HardwareInformations.HardwareInfo.VideoControllerList.Select(vc => vc.DriverVersion);
        }

        public IEnumerable<uint> GetHorizontalResolution()
        {
            return HardwareInformations.HardwareInfo.VideoControllerList.Select(vc => vc.CurrentHorizontalResolution);
        }

        public IEnumerable<string> GetManufacturer()
        {
            return HardwareInformations.HardwareInfo.VideoControllerList.Select(vc => vc.Manufacturer);
        }

        public IEnumerable<uint> GetMaxRefreshRate()
        {
            return HardwareInformations.HardwareInfo.VideoControllerList.Select(vc => vc.MaxRefreshRate);
        }

        public IEnumerable<uint> GetMinRefreshRate()
        {
            return HardwareInformations.HardwareInfo.VideoControllerList.Select(vc => vc.MinRefreshRate);
        }

        public IEnumerable<string> GetName()
        {
            return HardwareInformations.HardwareInfo.VideoControllerList.Select(vc => vc.Name);
        }

        public IEnumerable<uint> GetRefreshRate()
        {
            return HardwareInformations.HardwareInfo.VideoControllerList.Select(vc => vc.CurrentRefreshRate);
        }

        public IEnumerable<uint> GetVerticalResolution()
        {
            return HardwareInformations.HardwareInfo.VideoControllerList.Select(vc => vc.CurrentVerticalResolution);
        }

        public IEnumerable<string> GetVideoProcessor()
        {
            return HardwareInformations.HardwareInfo.VideoControllerList.Select(vc => vc.VideoProcessor);
        }

        public IEnumerable<ulong> GetVRAM()
        {
            return HardwareInformations.MachineInfo.Gpus.Select(vc => vc.AvailableVideoMemory);
        }
    }
}