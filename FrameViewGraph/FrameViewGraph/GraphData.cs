using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrameViewGraph
{
    internal class GraphData
    {
        public string Name { get; set; }
        public string Application { get; set; }
        public string GPU { get; set; }
        public string CPU { get; set; }
        public string Resolution { get; set; }
        public string Runtime { get; set; }
        public double[] TimeInSeconds { get; set; }
        public double[] MsBetweenPresents { get; set; }
        public double[] MsBetweenDisplayChange { get; set; }
        public int[] GPUClock { get; set; }
        public double avgGPUClock { get; set; }
        public int[] GPUMemClock { get; set; }
        public double avgGPUMemClock { get; set; }
        public int[] GPUUtil { get; set; }
        public double avgGPUUtil { get; set; }
        public int[] GPUTemp { get; set; }
        public double avgGPUTemp { get; set; }
        public int[] GPUPower { get; set; }
        public double avgGPUPower { get; set; }
        public int[] CPUClock { get; set; }
        public double avgCPUClock { get; set; }
        public int[] CPUUtil { get; set; }
        public double avgCPUUtil { get; set; }
        public int[] CPUTemp { get; set; }
        public double avgCPUTemp{ get; set; }
        public double[] CPUPower { get; set; }
        public double avgCPUPower{ get; set; }
        public int[,] CPUCoresUtil { get; set; }
        public double[] BatteryCapacity { get; set; }
        public double[] BatteryPercentage { get; set; }
        public double[] BatteryDrainRate { get; set; }
        public double AvgFPS { get; set; }
        public double ModeFPS { get; set; }
        public double _50FPS { get; set; }
        public double _10FPS { get; set; }
        public double _1FPS { get; set; }
        public double _01FPS { get; set; }

        public GraphData(string path)
        {
        }
    }
}
