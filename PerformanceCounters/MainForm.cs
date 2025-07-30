using PerformanceCounters.Performance_Pages;
using PerformanceCounters.PerformanceElements;
using System;
using System.Windows.Forms;

namespace PerformanceCounters
{
    public partial class MainForm : Form
    {
        readonly PerformanceCPU CPU = new PerformanceCPU();
        readonly PerformanceRAM RAM = new PerformanceRAM();
        readonly PerformanceDISK DISK = new PerformanceDISK();
        public MainForm()
        {
            InitializeComponent();
        }

        #region Переход по вкладкам
        //Центральный процессор
        private void ButtonCPU_Click(object sender, EventArgs e)
        {
            PerformancePanel.Controls.Clear();
            PerformancePanel.Controls.Add(CPU);
        }

        //Память
        private void ButtonRAM_Click(object sender, EventArgs e)
        {
            PerformancePanel.Controls.Clear();
            PerformancePanel.Controls.Add(RAM);
        }

        //Диск
        private void ButtonGPU_Click(object sender, EventArgs e)
        {
            PerformancePanel.Controls.Clear();
            PerformancePanel.Controls.Add(DISK);
        }

        //Закрепление в контейнере
        private void PerformancePanel_ControlAdded(object sender, ControlEventArgs e) => e.Control.Dock = DockStyle.Fill;
        #endregion

        private void BorderFormPanel_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                BorderFormPanel.Capture = false;

                const int WM_NCLBUTTONDOWN = 0x00A1, HTCAPTION = 2;

                Message msg = Message.Create(this.Handle, WM_NCLBUTTONDOWN, new IntPtr(HTCAPTION), IntPtr.Zero);
                this.DefWndProc(ref msg);
            }
        }
        private void ButtonClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
