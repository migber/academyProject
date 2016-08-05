using System.Drawing;
using System.Windows.Forms.DataVisualization.Charting;

namespace MB_FormsApplication1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea9 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend9 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Title title5 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea10 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend10 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.showingDataButton = new System.Windows.Forms.Button();
            this.computerName = new System.Windows.Forms.Label();
            this.userName = new System.Windows.Forms.Label();
            this.cpu = new System.Windows.Forms.Label();
            this.ram = new System.Windows.Forms.Label();
            this.vdieoCard = new System.Windows.Forms.Label();
            this.Ipadress = new System.Windows.Forms.Label();
            this.cpuUsage = new System.Windows.Forms.Label();
            this.ramUsage = new System.Windows.Forms.Label();
            this.availablediskSpace = new System.Windows.Forms.Label();
            this.averageDiskqueueLength = new System.Windows.Forms.Label();
            this.computerNameText = new System.Windows.Forms.TextBox();
            this.userNameText = new System.Windows.Forms.TextBox();
            this.cputextBox = new System.Windows.Forms.TextBox();
            this.ramtextBox = new System.Windows.Forms.TextBox();
            this.ipAddressTextBox = new System.Windows.Forms.TextBox();
            this.cpuUsageTextBox = new System.Windows.Forms.TextBox();
            this.ramUsageTextBox = new System.Windows.Forms.TextBox();
            this.availableDiskSpaceText = new System.Windows.Forms.TextBox();
            this.averagediskqueueLengthTextBox = new System.Windows.Forms.TextBox();
            this.videoCardtextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.averageDiskQueueLengthChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.DataTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TimetextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.averageDiskQueueLengthChart)).BeginInit();
            this.SuspendLayout();
            // 
            // showingDataButton
            // 
            this.showingDataButton.Location = new System.Drawing.Point(332, 291);
            this.showingDataButton.Name = "showingDataButton";
            this.showingDataButton.Size = new System.Drawing.Size(75, 23);
            this.showingDataButton.TabIndex = 0;
            this.showingDataButton.Text = "Show data";
            this.showingDataButton.UseVisualStyleBackColor = true;
            this.showingDataButton.Click += new System.EventHandler(this.showingDataButton_Click);
            // 
            // computerName
            // 
            this.computerName.AutoSize = true;
            this.computerName.Location = new System.Drawing.Point(12, 20);
            this.computerName.Name = "computerName";
            this.computerName.Size = new System.Drawing.Size(81, 13);
            this.computerName.TabIndex = 1;
            this.computerName.Text = "Computer name";
            this.computerName.Click += new System.EventHandler(this.label1_Click);
            // 
            // userName
            // 
            this.userName.AutoSize = true;
            this.userName.Location = new System.Drawing.Point(14, 43);
            this.userName.Name = "userName";
            this.userName.Size = new System.Drawing.Size(58, 13);
            this.userName.TabIndex = 2;
            this.userName.Text = "User name";
            // 
            // cpu
            // 
            this.cpu.AutoSize = true;
            this.cpu.Location = new System.Drawing.Point(16, 68);
            this.cpu.Name = "cpu";
            this.cpu.Size = new System.Drawing.Size(29, 13);
            this.cpu.TabIndex = 3;
            this.cpu.Text = "CPU";
            // 
            // ram
            // 
            this.ram.AutoSize = true;
            this.ram.Location = new System.Drawing.Point(14, 97);
            this.ram.Name = "ram";
            this.ram.Size = new System.Drawing.Size(31, 13);
            this.ram.TabIndex = 4;
            this.ram.Text = "RAM";
            // 
            // vdieoCard
            // 
            this.vdieoCard.AutoSize = true;
            this.vdieoCard.Location = new System.Drawing.Point(12, 122);
            this.vdieoCard.Name = "vdieoCard";
            this.vdieoCard.Size = new System.Drawing.Size(58, 13);
            this.vdieoCard.TabIndex = 5;
            this.vdieoCard.Text = "Video card";
            // 
            // Ipadress
            // 
            this.Ipadress.AutoSize = true;
            this.Ipadress.Location = new System.Drawing.Point(12, 144);
            this.Ipadress.Name = "Ipadress";
            this.Ipadress.Size = new System.Drawing.Size(57, 13);
            this.Ipadress.TabIndex = 6;
            this.Ipadress.Text = "IP address";
            // 
            // cpuUsage
            // 
            this.cpuUsage.AutoSize = true;
            this.cpuUsage.Location = new System.Drawing.Point(11, 174);
            this.cpuUsage.Name = "cpuUsage";
            this.cpuUsage.Size = new System.Drawing.Size(61, 13);
            this.cpuUsage.TabIndex = 7;
            this.cpuUsage.Text = "CPU usage";
            // 
            // ramUsage
            // 
            this.ramUsage.AutoSize = true;
            this.ramUsage.Location = new System.Drawing.Point(14, 206);
            this.ramUsage.Name = "ramUsage";
            this.ramUsage.Size = new System.Drawing.Size(63, 13);
            this.ramUsage.TabIndex = 8;
            this.ramUsage.Text = "RAM usage";
            // 
            // availablediskSpace
            // 
            this.availablediskSpace.AutoSize = true;
            this.availablediskSpace.Location = new System.Drawing.Point(11, 236);
            this.availablediskSpace.Name = "availablediskSpace";
            this.availablediskSpace.Size = new System.Drawing.Size(104, 13);
            this.availablediskSpace.TabIndex = 9;
            this.availablediskSpace.Text = "Available disk space";
            // 
            // averageDiskqueueLength
            // 
            this.averageDiskqueueLength.AutoSize = true;
            this.averageDiskqueueLength.Location = new System.Drawing.Point(11, 270);
            this.averageDiskqueueLength.Name = "averageDiskqueueLength";
            this.averageDiskqueueLength.Size = new System.Drawing.Size(137, 13);
            this.averageDiskqueueLength.TabIndex = 10;
            this.averageDiskqueueLength.Text = "Average disk queue length ";
            // 
            // computerNameText
            // 
            this.computerNameText.Location = new System.Drawing.Point(176, 16);
            this.computerNameText.Name = "computerNameText";
            this.computerNameText.Size = new System.Drawing.Size(231, 20);
            this.computerNameText.TabIndex = 11;
            // 
            // userNameText
            // 
            this.userNameText.Location = new System.Drawing.Point(176, 42);
            this.userNameText.Name = "userNameText";
            this.userNameText.Size = new System.Drawing.Size(231, 20);
            this.userNameText.TabIndex = 12;
            // 
            // cputextBox
            // 
            this.cputextBox.Location = new System.Drawing.Point(176, 68);
            this.cputextBox.Name = "cputextBox";
            this.cputextBox.Size = new System.Drawing.Size(231, 20);
            this.cputextBox.TabIndex = 13;
            // 
            // ramtextBox
            // 
            this.ramtextBox.Location = new System.Drawing.Point(176, 94);
            this.ramtextBox.Name = "ramtextBox";
            this.ramtextBox.Size = new System.Drawing.Size(231, 20);
            this.ramtextBox.TabIndex = 14;
            // 
            // ipAddressTextBox
            // 
            this.ipAddressTextBox.Location = new System.Drawing.Point(176, 141);
            this.ipAddressTextBox.Name = "ipAddressTextBox";
            this.ipAddressTextBox.Size = new System.Drawing.Size(231, 20);
            this.ipAddressTextBox.TabIndex = 15;
            // 
            // cpuUsageTextBox
            // 
            this.cpuUsageTextBox.Location = new System.Drawing.Point(176, 167);
            this.cpuUsageTextBox.Name = "cpuUsageTextBox";
            this.cpuUsageTextBox.Size = new System.Drawing.Size(231, 20);
            this.cpuUsageTextBox.TabIndex = 16;
            // 
            // ramUsageTextBox
            // 
            this.ramUsageTextBox.Location = new System.Drawing.Point(176, 199);
            this.ramUsageTextBox.Name = "ramUsageTextBox";
            this.ramUsageTextBox.Size = new System.Drawing.Size(231, 20);
            this.ramUsageTextBox.TabIndex = 17;
            // 
            // availableDiskSpaceText
            // 
            this.availableDiskSpaceText.Location = new System.Drawing.Point(176, 233);
            this.availableDiskSpaceText.Name = "availableDiskSpaceText";
            this.availableDiskSpaceText.Size = new System.Drawing.Size(231, 20);
            this.availableDiskSpaceText.TabIndex = 18;
            // 
            // averagediskqueueLengthTextBox
            // 
            this.averagediskqueueLengthTextBox.Location = new System.Drawing.Point(176, 263);
            this.averagediskqueueLengthTextBox.Name = "averagediskqueueLengthTextBox";
            this.averagediskqueueLengthTextBox.Size = new System.Drawing.Size(231, 20);
            this.averagediskqueueLengthTextBox.TabIndex = 19;
            // 
            // videoCardtextBox
            // 
            this.videoCardtextBox.Location = new System.Drawing.Point(176, 119);
            this.videoCardtextBox.Name = "videoCardtextBox";
            this.videoCardtextBox.Size = new System.Drawing.Size(231, 20);
            this.videoCardtextBox.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(413, 206);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "%";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(413, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "%";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(413, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "GB";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(413, 236);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(22, 13);
            this.label4.TabIndex = 24;
            this.label4.Text = "GB";
            // 
            // chart1
            // 
            chartArea9.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea9);
            this.chart1.Cursor = System.Windows.Forms.Cursors.Default;
            legend9.Name = "Legend1";
            this.chart1.Legends.Add(legend9);
            this.chart1.Location = new System.Drawing.Point(463, 68);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            this.chart1.Size = new System.Drawing.Size(429, 324);
            this.chart1.TabIndex = 25;
            this.chart1.Text = "chart1";
            title5.Name = "Data Time";
            this.chart1.Titles.Add(title5);
            this.chart1.Click += new System.EventHandler(this.chart1_Click);
            // 
            // averageDiskQueueLengthChart
            // 
            chartArea10.Name = "ChartArea1";
            this.averageDiskQueueLengthChart.ChartAreas.Add(chartArea10);
            legend10.Name = "Legend1";
            this.averageDiskQueueLengthChart.Legends.Add(legend10);
            this.averageDiskQueueLengthChart.Location = new System.Drawing.Point(924, 68);
            this.averageDiskQueueLengthChart.Name = "averageDiskQueueLengthChart";
            this.averageDiskQueueLengthChart.Size = new System.Drawing.Size(334, 324);
            this.averageDiskQueueLengthChart.TabIndex = 26;
            // 
            // DataTextBox
            // 
            this.DataTextBox.Location = new System.Drawing.Point(514, 20);
            this.DataTextBox.Name = "DataTextBox";
            this.DataTextBox.Size = new System.Drawing.Size(288, 20);
            this.DataTextBox.TabIndex = 27;
            this.DataTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(463, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 28;
            this.label5.Text = "Date:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(463, 42);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 13);
            this.label6.TabIndex = 29;
            this.label6.Text = "Time:";
            // 
            // TimetextBox
            // 
            this.TimetextBox.Location = new System.Drawing.Point(514, 40);
            this.TimetextBox.Name = "TimetextBox";
            this.TimetextBox.Size = new System.Drawing.Size(288, 20);
            this.TimetextBox.TabIndex = 30;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(708, 357);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 31;
            this.label7.Text = "Seconds";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(1112, 357);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 13);
            this.label8.TabIndex = 32;
            this.label8.Text = "Seconds";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1270, 439);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.TimetextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.DataTextBox);
            this.Controls.Add(this.averageDiskQueueLengthChart);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.videoCardtextBox);
            this.Controls.Add(this.averagediskqueueLengthTextBox);
            this.Controls.Add(this.availableDiskSpaceText);
            this.Controls.Add(this.ramUsageTextBox);
            this.Controls.Add(this.cpuUsageTextBox);
            this.Controls.Add(this.ipAddressTextBox);
            this.Controls.Add(this.ramtextBox);
            this.Controls.Add(this.cputextBox);
            this.Controls.Add(this.userNameText);
            this.Controls.Add(this.computerNameText);
            this.Controls.Add(this.averageDiskqueueLength);
            this.Controls.Add(this.availablediskSpace);
            this.Controls.Add(this.ramUsage);
            this.Controls.Add(this.cpuUsage);
            this.Controls.Add(this.Ipadress);
            this.Controls.Add(this.vdieoCard);
            this.Controls.Add(this.ram);
            this.Controls.Add(this.cpu);
            this.Controls.Add(this.userName);
            this.Controls.Add(this.computerName);
            this.Controls.Add(this.showingDataButton);
            this.Name = "Form1";
            this.Text = "Computer Metrics";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.averageDiskQueueLengthChart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button showingDataButton;
        private System.Windows.Forms.Label computerName;
        private System.Windows.Forms.Label userName;
        private System.Windows.Forms.Label cpu;
        private System.Windows.Forms.Label ram;
        private System.Windows.Forms.Label vdieoCard;
        private System.Windows.Forms.Label Ipadress;
        private System.Windows.Forms.Label cpuUsage;
        private System.Windows.Forms.Label ramUsage;
        private System.Windows.Forms.Label availablediskSpace;
        private System.Windows.Forms.Label averageDiskqueueLength;
        private System.Windows.Forms.TextBox computerNameText;
        private System.Windows.Forms.TextBox userNameText;
        private System.Windows.Forms.TextBox cputextBox;
        private System.Windows.Forms.TextBox ramtextBox;
        private System.Windows.Forms.TextBox ipAddressTextBox;
        private System.Windows.Forms.TextBox cpuUsageTextBox;
        private System.Windows.Forms.TextBox ramUsageTextBox;
        private System.Windows.Forms.TextBox availableDiskSpaceText;
        private System.Windows.Forms.TextBox averagediskqueueLengthTextBox;
        private System.Windows.Forms.TextBox videoCardtextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private Chart averageDiskQueueLengthChart;
        private System.Windows.Forms.TextBox DataTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TimetextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}

