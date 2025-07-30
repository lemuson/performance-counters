using System;
using System.Diagnostics;
using System.Threading;
using System.Windows.Forms;

namespace PerformanceCounters.PerformanceElements
{
    public partial class PerformanceRAM : UserControl
    {
        private readonly Thread UpdateThread;
        private bool IsUpdate = false;

        private readonly PerformanceCounter _CounterUsageRAM = new PerformanceCounter("Memory", "% Committed Bytes In Use");
        private readonly PerformanceCounter _CounterVirtualMemoryRAM = new PerformanceCounter("Memory", "Available Bytes");
        private readonly PerformanceCounter _CounterCacheRAM = new PerformanceCounter("Memory", "Cache Bytes");

        public PerformanceRAM()
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
                    PerformanceChart.Series["UsageRAM"].Points.Clear();
                    PerformanceChart.Series["VirtualMemoryRAM"].Points.Clear();
                    PerformanceChart.Series["CacheRAM"].Points.Clear();
                    PerformanceChart.ChartAreas[0].AxisX.Maximum = Convert.ToInt32(MaxTime.Text);

                    for (int i = 0; i <= PerformanceChart.ChartAreas[0].AxisX.Maximum; i++)
                    {
                        lock (Parent)
                        {
                            float usageValue = _CounterUsageRAM.NextValue();
                            float virtualMemoryValue = _CounterVirtualMemoryRAM.NextValue();
                            float cacheValue = _CounterCacheRAM.NextValue();

                            PerformanceChart.Invoke((MethodInvoker)(() =>
                            {
                                if (UsageRAM.Checked == true)
                                    PerformanceChart.Series["UsageRAM"].Points.AddXY(i, usageValue);

                                if (VirtualMemoryRAM.Checked == true)
                                    PerformanceChart.Series["VirtualMemoryRAM"].Points.AddXY(i, virtualMemoryValue);

                                if (CacheRAM.Checked == true)
                                    PerformanceChart.Series["CacheRAM"].Points.AddXY(i, cacheValue);
                            }));
                        }
                    Thread.Sleep(1000);
                    }
                    UsageRAM.Enabled = true;
                    VirtualMemoryRAM.Enabled = true;
                    CacheRAM.Enabled = true;
                    ButtonStart.Enabled = true;

                    IsUpdate = false;
                }
            }
        }

        #region Выбор счетчиков
        private void UsageRAM_CheckedChanged(object sender, EventArgs e)
        {
            if (UsageRAM.Checked == true)
                PerformanceChart.Series["UsageRAM"].Enabled = true;
            else
                PerformanceChart.Series["UsageRAM"].Enabled = false;
        }

        private void VirtualMemoryRAM_CheckedChanged(object sender, EventArgs e)
        {
            if (VirtualMemoryRAM.Checked == true)
                PerformanceChart.Series["VirtualMemoryRAM"].Enabled = true;
            else
                PerformanceChart.Series["VirtualMemoryRAM"].Enabled = false;
        }

        private void CacheRAM_CheckedChanged(object sender, EventArgs e)
        {
            if (CacheRAM.Checked == true)
                PerformanceChart.Series["CacheRAM"].Enabled = true;
            else
                PerformanceChart.Series["CacheRAM"].Enabled = false;
        }
        #endregion

        private void ButtonStart_Click(object sender, EventArgs e)
        {
            UsageRAM.Enabled = false;
            VirtualMemoryRAM.Enabled = false;
            CacheRAM.Enabled = false;
            ButtonStart.Enabled = false;

            IsUpdate = true;
            if (!UpdateThread.IsAlive)
                UpdateThread.Start();
        }
    }
}
