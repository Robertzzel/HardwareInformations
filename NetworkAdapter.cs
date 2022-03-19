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
        private HardwareInfo _hardwareInfo = new HardwareInfo();

        public NetworkAdapterMonitor()
        {
            _hardwareInfo.RefreshNetworkAdapterList();
        }

        public IEnumerable<string> GetCaption()
        {
            return _hardwareInfo.NetworkAdapterList.Select(na => na.Caption);
        }

        public IEnumerable<string> GetMACAddress()
        {
            return _hardwareInfo.NetworkAdapterList.Select(na => na.MACAddress);
        }

        public IEnumerable<string> GetManufacturer()
        {
            return _hardwareInfo.NetworkAdapterList.Select(na => na.Manufacturer);
        }

        public IEnumerable<string> GetName()
        {
            return _hardwareInfo.NetworkAdapterList.Select(na => na.Name);
        }

        public new IEnumerable<string> GetType()
        {
            return _hardwareInfo.NetworkAdapterList.Select(na => na.AdapterType);
        }
    }
}