using System;
using System.Diagnostics;
using System.Threading;
using System.Windows.Forms;

namespace PerformanceCounters.Performance_Pages
{
    public partial class PerformanceDISK : UserControl
    {
        private readonly Thread UpdateThread;
        private bool IsUpdate = false;

        private readonly PerformanceCounter _CounterSpeedWriteDISK = new PerformanceCounter("PhysicalDisk", "Disk Write Bytes/sec", "_Total", true);
        private readonly PerformanceCounter _CounterSpeedReadDISK = new PerformanceCounter("PhysicalDisk","Disk Read Bytes/sec", "_Total");
        private readonly PerformanceCounter _CounterActivityDISK = new PerformanceCounter("PhysicalDisk", "% Disk Time", "_Total", true);

        public PerformanceDISK()
        {
            InitializeComponent();

            UpdateThread = new Thread(() => UpdateValues());
            UpdateThread.IsBackground = true;
        }

        public void UpdateValues()
        {
            while (true)
            {
                if (IsUpdate)
                {
                    PerformanceChart.Series["SpeedWriteDISK"].Points.Clear();
                    PerformanceChart.Series["SpeedReadDISK"].Points.Clear();
                    PerformanceChart.Series["ActivityDISK"].Points.Clear();
                    PerformanceChart.ChartAreas[0].AxisX.Maximum = Convert.ToInt32(MaxTime.Text);

                    for (int i = 0; i <= PerformanceChart.ChartAreas[0].AxisX.Maximum; i++)
                    {
                        lock (Parent)
                        {
                            float writeValue = _CounterSpeedWriteDISK.NextValue();
                            float readValue = _CounterSpeedReadDISK.NextValue();
                            float activityValue = _CounterActivityDISK.NextValue();

                            PerformanceChart.Invoke((MethodInvoker)(() =>
                            {
                                if (SpeedWriteDISK.Checked)
                                    PerformanceChart.Series["SpeedWriteDISK"].Points.AddXY(i, writeValue);

                                if (SpeedReadDISK.Checked)
                                    PerformanceChart.Series["SpeedReadDISK"].Points.AddXY(i, readValue);

                                if (ActivityDISK.Checked)
                                    PerformanceChart.Series["ActivityDISK"].Points.AddXY(i, activityValue);
                            }));
                        }
                        Thread.Sleep(1000);
                    }
                    SpeedWriteDISK.Enabled = true;
                    SpeedReadDISK.Enabled = true;
                    ActivityDISK.Enabled = true;
                    ButtonStart.Enabled = true;

                    IsUpdate = false;
                }
            }
        }

        #region Выбор счетчиков
        private void SpeedWriteDISK_CheckedChanged(object sender, EventArgs e)
        {
            if (SpeedWriteDISK.Checked == true)
                PerformanceChart.Series["SpeedWriteDISK"].Enabled = true;
            else
                PerformanceChart.Series["SpeedWriteDISK"].Enabled = false;
        }

        private void SpeedReadDISK_CheckedChanged(object sender, EventArgs e)
        {
            if (SpeedReadDISK.Checked == true)
                PerformanceChart.Series["SpeedReadDISK"].Enabled = true;
            else
                PerformanceChart.Series["SpeedReadDISK"].Enabled = false;
        }

        private void ActivityDISK_CheckedChanged(object sender, EventArgs e)
        {
            if (ActivityDISK.Checked == true)
                PerformanceChart.Series["ActivityDISK"].Enabled = true;
            else
                PerformanceChart.Series["ActivityDISK"].Enabled = false;
        }
        #endregion

        private void ButtonStart_Click(object sender, EventArgs e)
        {
            SpeedWriteDISK.Enabled = false;
            SpeedReadDISK.Enabled = false;
            ActivityDISK.Enabled = false;
            ButtonStart.Enabled = false;

            IsUpdate = true;
            if(!UpdateThread.IsAlive)
                UpdateThread.Start();
        }
    }
}
