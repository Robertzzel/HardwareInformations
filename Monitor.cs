namespace Machine
{
    public  class Monitor
    {
        public ICPUMonitor cpuMonitor;
        public IGPUMonitor gpuMonitor;
        public INetworkAdapterMonitor networkAdapterMonitor;
        public IMotherboardMonitor motherboardMonitor;
        public IRAMMonitor ramMonitor;
        public IBatteryMonitor batteryMonitor;
        private static Monitor instance = null;

        private Monitor() 
        {
            cpuMonitor = new CPUMonitor();
            gpuMonitor = new GPUMonitor();
            networkAdapterMonitor = new NetworkAdapterMonitor();
            motherboardMonitor = new MotherboardMonitor();
            ramMonitor = new RAMMonitor();
            batteryMonitor = new BatteryMonitor();
        }

        public static Monitor getMonitor()
        {
            if(instance == null)
            {
                instance = new Monitor();
            }
            return instance;
        }
    }
}
