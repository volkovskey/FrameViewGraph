using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrameViewGraph
{
    internal class GraphData
    {
        private string Application { get; set; }
        private string GPU { get; set; }
        private string CPU { get; set; }
        private string Resolution { get; set; }
        private string Runtime { get; set; }
        private double[] TimeInSeconds { get; set; }
        private double[] MsBetweenPresents { get; set; }
        private double[] MsBetweenDisplayChange { get; set; }
        private int[] GPUClock { get; set; }
        private int[] GPUMemClock { get; set; }
        private int[] GPUUtil { get; set; }
        private int[] GPUTemp { get; set; }
        private int[] GPUPower { get; set; }
        private int[] CPUClock { get; set; }
        private int[] CPUUtil { get; set; }
        private int[] CPUTemp { get; set; }
        private double[] CPUPower { get; set; }
        private int[,] CPUCoresUtil { get; set; }
        private double[] BatteryCapacity { get; set; }
        private double[] BatteryPercentage { get; set; }
        private double[] BatteryDrainRate { get; set; }
        private double AvgFPS { get; set; }
        private double ModeFPS { get; set; }
        private double _50FPS { get; set; }
        private double _10FPS { get; set; }
        private double _1FPS { get; set; }
        private double _01FPS { get; set; }
    }
}
