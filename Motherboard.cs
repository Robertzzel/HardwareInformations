using Hardware.Info;

namespace Machine
{
    public interface IMotherboardMonitor
    {
        public string GetManufacturer();
        public string GetName();
        public string GetSerialNumber();
    }

    public class MotherboardMonitor : IMotherboardMonitor
    {
        private static HardwareInfo _hardwareInfo = new HardwareInfo();

        public string GetManufacturer()
        {
            return _hardwareInfo.MotherboardList[0].Manufacturer;
        }

        public string GetName()
        {
            return _hardwareInfo.MotherboardList[0].Product;
        }

        public string GetSerialNumber()
        {
            return _hardwareInfo.MotherboardList[0].SerialNumber;
        }
    }
}

