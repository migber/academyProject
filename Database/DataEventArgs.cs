using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database
{
    public class DataEventArgs: EventArgs
    {

        public DataEventArgs(string name,int cpuUsage, int ramUsage,
       int availableDiskSpaceGb, int averageDiskQueueLength)
        {

            //Time = time;
            Name = name;
            CpuUsage = cpuUsage;
            RamUsage = ramUsage;
            AvailableDiskSpaceGb = availableDiskSpaceGb;
            AverageDiskQueueLength = averageDiskQueueLength;
        }

       // public  DateTime Time { get; set; }
        public readonly string Name;
        public readonly int CpuUsage;
        public readonly int RamUsage;
        public readonly int AvailableDiskSpaceGb;
        public readonly int AverageDiskQueueLength;

    }
}
