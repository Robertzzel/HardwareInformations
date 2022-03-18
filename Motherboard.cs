using Hardware.Info;

namespace Machine
{
    public interface IMotherboard
    {
        public string Manufacturer { get; }
        public string Name { get; }
        public string SerialNumber { get; }
    }

    public class Motherboard : IMotherboard
    {
        private HardwareInfo _hardwareInfo = new HardwareInfo();
        public string Manufacturer => _hardwareInfo.MotherboardList[0].Manufacturer;
        public string Name => _hardwareInfo.MotherboardList[0].Product;
        public string SerialNumber => _hardwareInfo.MotherboardList[0].SerialNumber;
    }
}

