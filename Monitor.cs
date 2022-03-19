namespace Machine
{
    public  class Monitor
    {
        public ICPUMonitor cpuMonitor = new CPUMonitor();
        private IGPUMonitor _gpuMonitor = new GPUMonitor();
        private INetworkAdapterMonitor _networkAdapterMonitor = new NetworkAdapterMonitor();
        private IMotherboardMonitor _motherboardMonitor = new MotherboardMonitor();
        private IRAMMonitor _ramMonitor = new RAMMonitor();
        private IBatteryMonitor _batteryMonitor = new BatteryMonitor();
    }
}
