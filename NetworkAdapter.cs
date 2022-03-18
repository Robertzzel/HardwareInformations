using Hardware.Info;

namespace Machine
{
    public interface INetworkAdapter
    {
        public string Type { get; }
        public string Caption { get; }
        public string Name { get; }
        public string MACAddress { get; }
        public string Manufacturer { get; }
    }

    public class NetworkAdapter : INetworkAdapter
    {
        private HardwareInfo _hardwareInfo = new HardwareInfo();
        public string Type => _hardwareInfo.NetworkAdapterList[0].AdapterType;

        public string Caption => _hardwareInfo.NetworkAdapterList[0].Caption;

        public string Name => _hardwareInfo.NetworkAdapterList[0].Name;

        public string MACAddress => _hardwareInfo.NetworkAdapterList[0].MACAddress;

        public string Manufacturer => _hardwareInfo.NetworkAdapterList[0].Manufacturer;
    }
}