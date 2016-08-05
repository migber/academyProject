using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Windows.Forms.VisualStyles;
using Database;
using DatabaseAdder;
using DataLayer;


namespace MB_FormsApplication1
{
    public partial class Form1 : Form
    {
        private DataManager dataManager;
        private DataToSave savedData;

        public Form1()
        {
            InitializeComponent();

            dataManager = new FullDataManager();

            using (var context = new MetricsContext())
            {
                context.Database.EnsureCreated();
            }

             savedData = new DataToSave();

        }

        private void label1_Click(object sender, EventArgs e)
        { 

        }

        private void showingDataButton_Click(object sender, EventArgs e)
        {
            savedData.SaveToDatabaseComputerDetailsData();

            var dataFromDatabase = new MetricsContext();
            var dataFromCompDetails = dataFromDatabase.ComputerDetails.Last();
            
            computerNameText.Text = dataFromCompDetails.Name;
            userNameText.Text = dataFromCompDetails.User;
            cputextBox.Text = dataFromCompDetails.Cpu;
            ramtextBox.Text = dataFromCompDetails.Ram.ToString();
            videoCardtextBox.Text = dataFromCompDetails.VideoCard;
            ipAddressTextBox.Text = dataFromCompDetails.Ip;
            

            chart1.Series.Clear();
            averageDiskQueueLengthChart.Series.Clear();
            AddSeriesToChart1();
            AddSeriesToAverageDiskQueueLengthChart();

            // With this it will show live data
            Clock clock = new Clock();
            clock.SecondChange += ClockOnSecondChange;
            clock.Run();
           
           // Uncomment this lines and comment three line above you will write data to database from DataToSave object
            //savedData.SetClockAndIndformation();
            //uncomment this line bottom and you will get dataFromdatabase
           // TakeDataFromDatabase();
                }

                private void ClockOnSecondChange(object clock, DataEventArgs dataInformation)
                {

                    var usageData = new UsageData();
                    DateTime date_time = SetTime();
                    var time = date_time.ToString("mm:ss");
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
                                Time = date_time
                            });
                            context.SaveChanges();
                        }
                    }
                    cpuUsageTextBox.Text = dataInformation.CpuUsage.ToString();
                    ramUsageTextBox.Text = dataInformation.RamUsage.ToString();
                    availableDiskSpaceText.Text = dataInformation.AvailableDiskSpaceGb.ToString();
                    averagediskqueueLengthTextBox.Text = dataInformation.AverageDiskQueueLength.ToString();

                    chart1.Series[0].Points.AddXY(time, dataInformation.RamUsage);
                    chart1.Series[1].Points.AddXY(time, dataInformation.CpuUsage);
                    chart1.Series[2].Points.AddXY(time, dataInformation.AvailableDiskSpaceGb);
                    averageDiskQueueLengthChart.Series[0].Points.AddXY(time,
                        dataInformation.AverageDiskQueueLength);
                    OnlyTenPointsInTheGraph();
                }

        public DateTime SetTime()
        {
            DateTime time = DateTime.Now;

            DataTextBox.Text = time.ToString("d");
            var time1 = time.ToString("mm:ss");
            TimetextBox.Text = time.ToString("T");
            return time;
        }

        public void TakeDataFromDatabase()
        {
            using (var contexMetrics = new MetricsContext())
            {
                var usageDataFromDatabase = contexMetrics.UsageDatas.ToList().GetRange(0,11); // make list of 10 first data from database
                foreach (var usageData in usageDataFromDatabase)
                {
                    cpuUsageTextBox.Text = usageData.CpuUsage.ToString();
                    ramUsageTextBox.Text = usageData.RamUsage.ToString();
                    availableDiskSpaceText.Text = usageData.AvailableDiskSpaceGb.ToString();
                    averagediskqueueLengthTextBox.Text = usageData.AverageDiskQueueLength.ToString();

                    if (usageData.Time != null)
                    {
                        chart1.Series[0].Points.AddXY(usageData.Time.Value.Second, usageData.RamUsage);
                        chart1.Series[1].Points.AddXY(usageData.Time.Value.Second, usageData.CpuUsage);
                        chart1.Series[2].Points.AddXY(usageData.Time.Value.Second, usageData.AvailableDiskSpaceGb);
                        averageDiskQueueLengthChart.Series[0].Points.AddXY(usageData.Time.Value.Second,
                            usageData.AverageDiskQueueLength);
                    }
                }
            }
        }
        public void OnlyTenPointsInTheGraph()
        {
            while (chart1.Series[0].Points.Count > 10)
            {
                chart1.Series[0].Points.RemoveAt(0);
            }

            while (chart1.Series[1].Points.Count > 10)
            {
                chart1.Series[1].Points.RemoveAt(0);
            }
            while (chart1.Series[2].Points.Count > 10)
            {
                chart1.Series[2].Points.RemoveAt(0);
            }

            while (averageDiskQueueLengthChart.Series[0].Points.Count > 10)
            {
                averageDiskQueueLengthChart.Series[0].Points.RemoveAt(0);
            }

        }

        private void AddSeriesToChart1()
        {
            Series ramUsageSeries = new Series
            {
                Name = "RAM usage",
                ChartType = SeriesChartType.Line,
                Color = Color.Blue
            };

            Series cpuUsageSeries = new Series
            {
                Name = "CPU usage",
                ChartType = SeriesChartType.Line,
                Color = Color.Aqua
            };

            Series availableDiskSpaceSeries = new Series
            {
                Name = "Available disk space GB",
                ChartType = SeriesChartType.Line,
                Color = Color.Brown
            };

            chart1.Series.Add(ramUsageSeries);
            chart1.Series.Add(cpuUsageSeries);
            chart1.Series.Add(availableDiskSpaceSeries);

            chart1.ChartAreas[0].AxisY.Maximum = 100;
        }

        private void AddSeriesToAverageDiskQueueLengthChart()
        {
            Series averageDiskQueueLengthSeries = new Series
            {
                Name = "Average disk queue length",
                ChartType = SeriesChartType.Line,
                Color = Color.BlueViolet
            };
            averageDiskQueueLengthChart.Series.Add(averageDiskQueueLengthSeries);
            averageDiskQueueLengthChart.ChartAreas[0].AxisY.Maximum = 100;
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        


       /* private void timer1_Tick(object sender, EventArgs e)
        {
            
        }*/

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        /*    private void label5_Click(object sender, EventArgs e)
            {

            }

            private void jjj(object sender, EventArgs e)
            {

            }*/
    }
}
