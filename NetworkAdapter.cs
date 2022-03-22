using Hardware.Info;

namespace Machine
{
    public interface INetworkAdapterMonitor
    {
        public IEnumerable<string> GetType();
        public IEnumerable<string> GetCaption();
        public IEnumerable<string> GetName();
        public IEnumerable<string> GetMACAddress();
        public IEnumerable<string> GetManufacturer();
    }


    public class NetworkAdapterMonitor : INetworkAdapterMonitor
    {
        public IEnumerable<string> GetCaption()
        {
            return HardwareInformations.HardwareInfo.NetworkAdapterList.Select(na => na.Caption);
        }

        public IEnumerable<string> GetMACAddress()
        {
            return HardwareInformations.HardwareInfo.NetworkAdapterList.Select(na => na.MACAddress);
        }

        public IEnumerable<string> GetManufacturer()
        {
            return HardwareInformations.HardwareInfo.NetworkAdapterList.Select(na => na.Manufacturer);
        }

        public IEnumerable<string> GetName()
        {
            return HardwareInformations.HardwareInfo.NetworkAdapterList.Select(na => na.Name);
        }

        public new IEnumerable<string> GetType()
        {
            return HardwareInformations.HardwareInfo.NetworkAdapterList.Select(na => na.AdapterType);
        }
    }
}