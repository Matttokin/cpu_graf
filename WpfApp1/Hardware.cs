using OpenHardwareMonitor.Hardware;
using System;
using System.Management;

namespace WpfApp1
{
    public class Hardware
    {
        /**/
        public int gpuTemp { get { return _gpuTemp; } }
        private int _gpuTemp;
        public int gpuTempMax { get { return _gpuTempMax; } }
        private int _gpuTempMax;
        /**/

        /**/
        public int cpuTempFull { get { return _cpuTempFull; } }
        private int _cpuTempFull;

        public int cpuTempMaxFull { get { return _cpuTempMaxFull; } }
        private int _cpuTempMaxFull;
        /**/
        
        public class UpdateVisitor : IVisitor
        {
            public void VisitComputer(IComputer computer)
            {
                computer.Traverse(this);
            }
            public void VisitHardware(IHardware hardware)
            {
                hardware.Update();
                foreach (IHardware subHardware in hardware.SubHardware) subHardware.Accept(this);
            }
            public void VisitSensor(ISensor sensor) { }
            public void VisitParameter(IParameter parameter) { }
        }
        public Hardware()
        {
        }
        public void getInfo()
        {
            try
            {
                Computer computer = new Computer();
                computer.Open();
                computer.CPUEnabled = true;
                computer.GPUEnabled = true;
                UpdateVisitor updateVisitor = new UpdateVisitor();
                computer.Accept(updateVisitor);

                for (int i = 0; i < computer.Hardware.Length; i++)
                {
                    if (computer.Hardware[i].HardwareType == HardwareType.CPU)
                    {
                        for (int j = 0; j < computer.Hardware[i].Sensors.Length; j++)
                        {
                            if (computer.Hardware[i].Sensors[j].SensorType == SensorType.Temperature && computer.Hardware[i].Sensors[j].Name.Equals("CPU Package"))
                                this._cpuTempFull = Convert.ToInt32(computer.Hardware[i].Sensors[j].Value);
                            if (this._cpuTempFull > this._cpuTempMaxFull) this._cpuTempMaxFull = this._cpuTempFull;
                        }
                    }

                    if (computer.Hardware[i].HardwareType == HardwareType.GpuNvidia || computer.Hardware[i].HardwareType == HardwareType.GpuAti)
                    {
                        for (int j = 0; j < computer.Hardware[i].Sensors.Length; j++)
                        {
                            if (computer.Hardware[i].Sensors[j].SensorType == SensorType.Temperature && computer.Hardware[i].Sensors[j].Name.Equals("GPU Core"))
                                this._gpuTemp = Convert.ToInt32(computer.Hardware[i].Sensors[j].Value);
                            if (this._gpuTemp > this._gpuTempMax) this._gpuTempMax = this._gpuTemp;
                        }
                    }
                }

                computer.Close();

            }
            catch (ManagementException e)
            {
                Console.Error.WriteLine(e.Message);
            }
        }
    }
}

