using Hardware.Info;

namespace Machine
{
    public class NetworkAdapter
    {
        public string Type { get; set; } = String.Empty;
        public string Caption { get; set; } = String.Empty;
        public string Name { get; set; } = String.Empty;
        public string MACAddress { get; set; } = String.Empty; 
        public string Manufacturer { get; set; } = String.Empty;
    }

    public interface INetworkAdapterMonitor
    {
        public IEnumerable<NetworkAdapter> GetNetworkAdapters();
    }

    public class NetworkAdapterMonitor : INetworkAdapterMonitor
    {
        private HardwareInfo _hardwareInfo = new HardwareInfo();

        public IEnumerable<NetworkAdapter> GetNetworkAdapters()
        {
            List<NetworkAdapter> networkAdapters = new List<NetworkAdapter>();
            _hardwareInfo.RefreshAll();

            foreach (var networkAdapter in _hardwareInfo.NetworkAdapterList)
            {
                networkAdapters.Add
                (
                    new NetworkAdapter
                    {
                        Type = networkAdapter.AdapterType,
                        Name = networkAdapter.Name,
                        MACAddress = networkAdapter.MACAddress,
                        Manufacturer = networkAdapter.Manufacturer,
                        Caption = networkAdapter.Caption,
                    }
                );
            }

            return networkAdapters;
        }
    }
}