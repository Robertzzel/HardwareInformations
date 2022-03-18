using Hardware.Info;

namespace Machine
{
    public class Motherboard
    {
        public string Manufacturer { get; set; } = String.Empty;
        public string Name { get; set; } = String.Empty;
        public string SerialNumber { get; set; } = String.Empty;
    }

    public interface IMotherboardMonitor
    {
        public IEnumerable<Motherboard> GetMotherboards();
    }

    public class MotherboardMonitor : IMotherboardMonitor
    {
        private HardwareInfo _hardwareInfo = new HardwareInfo();

        public IEnumerable<Motherboard> GetMotherboards()
        {
            List<Motherboard> motherboards = new List<Motherboard>();
            _hardwareInfo.RefreshAll();

            foreach(var motherboard in _hardwareInfo.MotherboardList)
            {
                motherboards.Add
                (
                    new Motherboard
                    {
                        Manufacturer = motherboard.Manufacturer,
                        Name = motherboard.Product,
                        SerialNumber = motherboard.SerialNumber,
                    }
                );
            }

            return motherboards;
        }
    }
}

