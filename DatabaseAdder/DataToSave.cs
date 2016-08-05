using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using DataLayer;
using Database;

namespace DatabaseAdder
{
    public class DataToSave
    {
        public DataToSave()
        {
            

            using (var context = new MetricsContext())
            {
                context.Database.EnsureCreated();
            }
            
        }
         public void SetClockAndIndformation()
         {
             Clock clock = new Clock();
             clock.SecondChange += ClockOnSecondChange;
             clock.Run();
        }

        private void ClockOnSecondChange(object clock, DataEventArgs dataInformation)
        {
            var usageData = new UsageData();
            DateTime time = DateTime.Now;
            using (var context = new MetricsContext())
            {
                var metrics =
                    context.ComputerDetails.FirstOrDefault(n => n.Name == dataInformation.Name);
                if (metrics != null)
                {
                    metrics.UsageDataCollection.Add(new UsageData()
                    {
                        CpuUsage = dataInformation.CpuUsage,
                        AvailableDiskSpaceGb = dataInformation.AvailableDiskSpaceGb,
                        RamUsage = dataInformation.RamUsage,
                        AverageDiskQueueLength = dataInformation.AverageDiskQueueLength,
                        Time = time
                    });
                    context.SaveChanges();
                }
            }

        }

        public void SaveToDatabaseComputerDetailsData()
        {
            DataManager dataManager = new FullDataManager();
            var computerSummary = dataManager.GetComputerSummary();
            var context1 = new MetricsContext();
            ComputerDetail computerDetail = new ComputerDetail()
            {
                Name = computerSummary.Name,
                User = computerSummary.User,
                Cpu = computerSummary.Cpu,
                Ram = computerSummary.Ram,
                VideoCard = computerSummary.VideoCard,
                Ip = computerSummary.Ip.ToString()
            };
            if (context1.ComputerDetails.Count() != 0)
            {
                if (context1.ComputerDetails.Last().Name != computerDetail.Name)
                {
                    context1.Add(computerDetail);
                    context1.SaveChanges();
                }
            }
            else
            {
                context1.Add(computerDetail);
                context1.SaveChanges();
            }
        }
    }
}
