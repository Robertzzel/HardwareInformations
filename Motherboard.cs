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
        public string GetManufacturer()
        {
            return HardwareInformations.HardwareInfo.MotherboardList[0].Manufacturer;
        }

        public string GetName()
        {
            return HardwareInformations.HardwareInfo.MotherboardList[0].Product;
        }

        public string GetSerialNumber()
        {
            return HardwareInformations.HardwareInfo.MotherboardList[0].SerialNumber;
        }
    }
}

