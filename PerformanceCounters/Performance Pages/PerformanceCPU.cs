using System;
using System.Diagnostics;
using System.Threading;
using System.Windows.Forms;

namespace PerformanceCounters.PerformanceElements
{
    public partial class PerformanceCPU : UserControl
    {
        private readonly Thread UpdateThread;
        private bool IsUpdate = false;

        private readonly PerformanceCounter _CounterUsageCPU = new PerformanceCounter("Processor", "% Processor Time", "_Total");
        private readonly PerformanceCounter _CounterIdleCPU = new PerformanceCounter("Processor", "% Idle Time", "_Total");
        private readonly PerformanceCounter _CounterPrivilegedModeCPU = new PerformanceCounter("Processor", "% Privileged Time", "_Total");

        public PerformanceCPU()
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
                    
                    PerformanceChart.Series["UsageCPU"].Points.Clear();
                    PerformanceChart.Series["PrivilegedModeCPU"].Points.Clear();
                    PerformanceChart.Series["IdleCPU"].Points.Clear();
                    PerformanceChart.ChartAreas[0].AxisX.Maximum = Convert.ToInt32(MaxTime.Text);

                    for (int i = 0; i <= PerformanceChart.ChartAreas[0].AxisX.Maximum; i++)
                    {
                        lock (Parent)
                        {
                            float usageValue = _CounterUsageCPU.NextValue();
                            float privilegedModeValue = _CounterPrivilegedModeCPU.NextValue();
                            float idleValue = _CounterIdleCPU.NextValue();

                            PerformanceChart.Invoke((MethodInvoker)(() =>
                            {
                                if (UsageCPU.Checked == true)
                                    PerformanceChart.Series["UsageCPU"].Points.AddXY(i, usageValue);

                                if (PrivilegedModeCPU.Checked == true)
                                    PerformanceChart.Series["PrivilegedModeCPU"].Points.AddXY(i, privilegedModeValue);

                                if (IdleCPU.Checked == true)
                                    PerformanceChart.Series["IdleCPU"].Points.AddXY(i, idleValue);
                            }));
                        }
                        Thread.Sleep(1000);
                    }
                    UsageCPU.Enabled = true;
                    PrivilegedModeCPU.Enabled = true;
                    IdleCPU.Enabled = true;
                    ButtonStart.Enabled = true;

                    IsUpdate = false;
                }
            }
        }

        #region Выбор счетчиков
        private void CounterUsageCPU_CheckedChanged(object sender, EventArgs e)
        {
            if (UsageCPU.Checked == true)
                PerformanceChart.Series["UsageCPU"].Enabled = true;
            else
                PerformanceChart.Series["UsageCPU"].Enabled = false;
        }

        private void CounterPrivilegedModeCPU_CheckedChanged(object sender, EventArgs e)
        {
            if (PrivilegedModeCPU.Checked == true)
                PerformanceChart.Series["PrivilegedModeCPU"].Enabled = true;
            else
                PerformanceChart.Series["PrivilegedModeCPU"].Enabled = false;
        }

        private void CounterIdleCPU_CheckedChanged(object sender, EventArgs e)
        {
            if (IdleCPU.Checked == true)
                PerformanceChart.Series["IdleCPU"].Enabled = true;
            else
                PerformanceChart.Series["IdleCPU"].Enabled = false;
        }
        #endregion

        private void ButtonStart_Click(object sender, EventArgs e)
        {
            UsageCPU.Enabled = false;
            PrivilegedModeCPU.Enabled = false;
            IdleCPU.Enabled = false;
            ButtonStart.Enabled = false;

            IsUpdate = true;
            if (!UpdateThread.IsAlive)
                UpdateThread.Start();
        }
    }
}
