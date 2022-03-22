using HardwareInformation;
using Hardware.Info;

namespace Machine
{
    public class HardwareInformations
    {
        private static HardwareInfo _hardwareInfo = new HardwareInfo();
        private static MachineInformation _machineInfo = MachineInformationGatherer.GatherInformation();
        private static bool hasBeenUpdated = false;

        public static MachineInformation MachineInfo => _machineInfo;
        public static HardwareInfo HardwareInfo
        {
            get
            {
                if (!hasBeenUpdated)
                {
                    _hardwareInfo.RefreshCPUList();
                    _hardwareInfo.RefreshVideoControllerList();
                    _hardwareInfo.RefreshBatteryList();
                    _hardwareInfo.RefreshMemoryList();
                    hasBeenUpdated = true;
                }
                    
                return _hardwareInfo;
            }
        }
    }
}
