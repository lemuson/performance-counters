namespace PerformanceCounters.PerformanceElements
{
    partial class PerformanceRAM
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series10 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series11 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series12 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.ChartPanel = new System.Windows.Forms.Panel();
            this.PerformanceChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.PanelSeries = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.MaxTime = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ButtonStart = new System.Windows.Forms.Button();
            this.VirtualMemoryRAM = new System.Windows.Forms.CheckBox();
            this.CacheRAM = new System.Windows.Forms.CheckBox();
            this.UsageRAM = new System.Windows.Forms.CheckBox();
            this.ChartPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PerformanceChart)).BeginInit();
            this.PanelSeries.SuspendLayout();
            this.SuspendLayout();
            // 
            // ChartPanel
            // 
            this.ChartPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ChartPanel.Controls.Add(this.PerformanceChart);
            this.ChartPanel.Controls.Add(this.PanelSeries);
            this.ChartPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ChartPanel.Location = new System.Drawing.Point(0, 0);
            this.ChartPanel.Name = "ChartPanel";
            this.ChartPanel.Size = new System.Drawing.Size(612, 416);
            this.ChartPanel.TabIndex = 8;
            // 
            // PerformanceChart
            // 
            chartArea4.AxisX.Interval = 5D;
            chartArea4.AxisX.Maximum = 60D;
            chartArea4.AxisX.Minimum = 0D;
            chartArea4.Name = "ChartArea1";
            this.PerformanceChart.ChartAreas.Add(chartArea4);
            this.PerformanceChart.Dock = System.Windows.Forms.DockStyle.Fill;
            legend4.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend4.Font = new System.Drawing.Font("Jost", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            legend4.IsTextAutoFit = false;
            legend4.Name = "Legend1";
            this.PerformanceChart.Legends.Add(legend4);
            this.PerformanceChart.Location = new System.Drawing.Point(0, 0);
            this.PerformanceChart.Name = "PerformanceChart";
            this.PerformanceChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            series10.BorderWidth = 3;
            series10.ChartArea = "ChartArea1";
            series10.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series10.Legend = "Legend1";
            series10.LegendText = "% использования выделенной памяти";
            series10.Name = "UsageRAM";
            series11.BorderWidth = 3;
            series11.ChartArea = "ChartArea1";
            series11.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series11.Legend = "Legend1";
            series11.LegendText = "Байт виртуальной памяти";
            series11.Name = "VirtualMemoryRAM";
            series12.BorderWidth = 3;
            series12.ChartArea = "ChartArea1";
            series12.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series12.Legend = "Legend1";
            series12.LegendText = "Байт кэш-памяти";
            series12.Name = "CacheRAM";
            this.PerformanceChart.Series.Add(series10);
            this.PerformanceChart.Series.Add(series11);
            this.PerformanceChart.Series.Add(series12);
            this.PerformanceChart.Size = new System.Drawing.Size(610, 311);
            this.PerformanceChart.TabIndex = 3;
            // 
            // PanelSeries
            // 
            this.PanelSeries.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelSeries.Controls.Add(this.label2);
            this.PanelSeries.Controls.Add(this.MaxTime);
            this.PanelSeries.Controls.Add(this.label1);
            this.PanelSeries.Controls.Add(this.ButtonStart);
            this.PanelSeries.Controls.Add(this.VirtualMemoryRAM);
            this.PanelSeries.Controls.Add(this.CacheRAM);
            this.PanelSeries.Controls.Add(this.UsageRAM);
            this.PanelSeries.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PanelSeries.Font = new System.Drawing.Font("Jost", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PanelSeries.Location = new System.Drawing.Point(0, 311);
            this.PanelSeries.Name = "PanelSeries";
            this.PanelSeries.Size = new System.Drawing.Size(610, 103);
            this.PanelSeries.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(569, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 23);
            this.label2.TabIndex = 8;
            this.label2.Text = "сек.";
            // 
            // MaxTime
            // 
            this.MaxTime.Font = new System.Drawing.Font("Jost", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MaxTime.Location = new System.Drawing.Point(518, 40);
            this.MaxTime.Name = "MaxTime";
            this.MaxTime.Size = new System.Drawing.Size(49, 26);
            this.MaxTime.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(461, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 23);
            this.label1.TabIndex = 6;
            this.label1.Text = "Время:";
            // 
            // ButtonStart
            // 
            this.ButtonStart.Font = new System.Drawing.Font("High Tower Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonStart.Location = new System.Drawing.Point(464, 67);
            this.ButtonStart.Name = "ButtonStart";
            this.ButtonStart.Size = new System.Drawing.Size(143, 29);
            this.ButtonStart.TabIndex = 5;
            this.ButtonStart.Text = "Старт";
            this.ButtonStart.UseVisualStyleBackColor = true;
            this.ButtonStart.Click += new System.EventHandler(this.ButtonStart_Click);
            // 
            // VirtualMemoryRAM
            // 
            this.VirtualMemoryRAM.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.VirtualMemoryRAM.AutoSize = true;
            this.VirtualMemoryRAM.Checked = true;
            this.VirtualMemoryRAM.CheckState = System.Windows.Forms.CheckState.Checked;
            this.VirtualMemoryRAM.Location = new System.Drawing.Point(7, 36);
            this.VirtualMemoryRAM.Name = "VirtualMemoryRAM";
            this.VirtualMemoryRAM.Size = new System.Drawing.Size(204, 27);
            this.VirtualMemoryRAM.TabIndex = 4;
            this.VirtualMemoryRAM.Text = "Байт виртуальной памяти";
            this.VirtualMemoryRAM.UseVisualStyleBackColor = true;
            this.VirtualMemoryRAM.CheckedChanged += new System.EventHandler(this.VirtualMemoryRAM_CheckedChanged);
            // 
            // CacheRAM
            // 
            this.CacheRAM.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.CacheRAM.AutoSize = true;
            this.CacheRAM.Checked = true;
            this.CacheRAM.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CacheRAM.Location = new System.Drawing.Point(7, 69);
            this.CacheRAM.Name = "CacheRAM";
            this.CacheRAM.Size = new System.Drawing.Size(141, 27);
            this.CacheRAM.TabIndex = 3;
            this.CacheRAM.Text = "Байт кэш-памяти";
            this.CacheRAM.UseVisualStyleBackColor = true;
            this.CacheRAM.CheckedChanged += new System.EventHandler(this.CacheRAM_CheckedChanged);
            // 
            // UsageRAM
            // 
            this.UsageRAM.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.UsageRAM.AutoSize = true;
            this.UsageRAM.Checked = true;
            this.UsageRAM.CheckState = System.Windows.Forms.CheckState.Checked;
            this.UsageRAM.Location = new System.Drawing.Point(7, 3);
            this.UsageRAM.Name = "UsageRAM";
            this.UsageRAM.Size = new System.Drawing.Size(300, 27);
            this.UsageRAM.TabIndex = 0;
            this.UsageRAM.Text = "% использования выделенной памяти";
            this.UsageRAM.UseVisualStyleBackColor = true;
            this.UsageRAM.CheckedChanged += new System.EventHandler(this.UsageRAM_CheckedChanged);
            // 
            // PerformanceRAM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ChartPanel);
            this.Name = "PerformanceRAM";
            this.Size = new System.Drawing.Size(612, 416);
            this.ChartPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PerformanceChart)).EndInit();
            this.PanelSeries.ResumeLayout(false);
            this.PanelSeries.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel ChartPanel;
        private System.Windows.Forms.DataVisualization.Charting.Chart PerformanceChart;
        private System.Windows.Forms.Panel PanelSeries;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox MaxTime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ButtonStart;
        private System.Windows.Forms.CheckBox VirtualMemoryRAM;
        private System.Windows.Forms.CheckBox CacheRAM;
        private System.Windows.Forms.CheckBox UsageRAM;
    }
}
