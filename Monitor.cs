namespace Machine
{
    public  class Monitor
    {
        public ICPUMonitor _cpuMonitor = new CPUMonitor();
        public IGPUMonitor _gpuMonitor = new GPUMonitor();
        public INetworkAdapterMonitor _networkAdapterMonitor = new NetworkAdapterMonitor();
        public IMotherboardMonitor _motherboardMonitor = new MotherboardMonitor();
        public IRAMMonitor _ramMonitor = new RAMMonitor();
        public IBatteryMonitor _batteryMonitor = new BatteryMonitor();
    }
}
