namespace PerformanceCounters.PerformanceElements
{
    partial class PerformanceCPU
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.PerformanceChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.PanelSeries = new System.Windows.Forms.Panel();
            this.PrivilegedModeCPU = new System.Windows.Forms.CheckBox();
            this.IdleCPU = new System.Windows.Forms.CheckBox();
            this.UsageCPU = new System.Windows.Forms.CheckBox();
            this.ButtonStart = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.MaxTime = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PerformanceChart)).BeginInit();
            this.PanelSeries.SuspendLayout();
            this.SuspendLayout();
            // 
            // PerformanceChart
            // 
            chartArea1.AxisX.Interval = 5D;
            chartArea1.AxisX.Maximum = 60D;
            chartArea1.AxisX.Minimum = 0D;
            chartArea1.Name = "ChartArea1";
            this.PerformanceChart.ChartAreas.Add(chartArea1);
            this.PerformanceChart.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend1.Font = new System.Drawing.Font("Jost", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            legend1.IsTextAutoFit = false;
            legend1.Name = "Legend1";
            this.PerformanceChart.Legends.Add(legend1);
            this.PerformanceChart.Location = new System.Drawing.Point(0, 0);
            this.PerformanceChart.Name = "PerformanceChart";
            this.PerformanceChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            series1.BorderWidth = 3;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.LegendText = "% загруженности процессора";
            series1.Name = "UsageCPU";
            series2.BorderWidth = 3;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Legend = "Legend1";
            series2.LegendText = "% работы в привелегированном режиме";
            series2.Name = "PrivilegedModeCPU";
            series3.BorderWidth = 3;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Legend = "Legend1";
            series3.LegendText = "% времени бездействия";
            series3.Name = "IdleCPU";
            this.PerformanceChart.Series.Add(series1);
            this.PerformanceChart.Series.Add(series2);
            this.PerformanceChart.Series.Add(series3);
            this.PerformanceChart.Size = new System.Drawing.Size(612, 313);
            this.PerformanceChart.TabIndex = 2;
            // 
            // PanelSeries
            // 
            this.PanelSeries.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelSeries.Controls.Add(this.label2);
            this.PanelSeries.Controls.Add(this.MaxTime);
            this.PanelSeries.Controls.Add(this.label1);
            this.PanelSeries.Controls.Add(this.ButtonStart);
            this.PanelSeries.Controls.Add(this.PrivilegedModeCPU);
            this.PanelSeries.Controls.Add(this.IdleCPU);
            this.PanelSeries.Controls.Add(this.UsageCPU);
            this.PanelSeries.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PanelSeries.Font = new System.Drawing.Font("Jost", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PanelSeries.Location = new System.Drawing.Point(0, 313);
            this.PanelSeries.Name = "PanelSeries";
            this.PanelSeries.Size = new System.Drawing.Size(612, 103);
            this.PanelSeries.TabIndex = 6;
            // 
            // PrivilegedModeCPU
            // 
            this.PrivilegedModeCPU.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.PrivilegedModeCPU.AutoSize = true;
            this.PrivilegedModeCPU.Checked = true;
            this.PrivilegedModeCPU.CheckState = System.Windows.Forms.CheckState.Checked;
            this.PrivilegedModeCPU.Location = new System.Drawing.Point(7, 36);
            this.PrivilegedModeCPU.Name = "PrivilegedModeCPU";
            this.PrivilegedModeCPU.Size = new System.Drawing.Size(314, 27);
            this.PrivilegedModeCPU.TabIndex = 4;
            this.PrivilegedModeCPU.Text = "% работы в привелегированном режиме";
            this.PrivilegedModeCPU.UseVisualStyleBackColor = true;
            this.PrivilegedModeCPU.CheckedChanged += new System.EventHandler(this.CounterPrivilegedModeCPU_CheckedChanged);
            // 
            // IdleCPU
            // 
            this.IdleCPU.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.IdleCPU.AutoSize = true;
            this.IdleCPU.Checked = true;
            this.IdleCPU.CheckState = System.Windows.Forms.CheckState.Checked;
            this.IdleCPU.Location = new System.Drawing.Point(7, 69);
            this.IdleCPU.Name = "IdleCPU";
            this.IdleCPU.Size = new System.Drawing.Size(199, 27);
            this.IdleCPU.TabIndex = 3;
            this.IdleCPU.Text = "% времени бездействия";
            this.IdleCPU.UseVisualStyleBackColor = true;
            this.IdleCPU.CheckedChanged += new System.EventHandler(this.CounterIdleCPU_CheckedChanged);
            // 
            // UsageCPU
            // 
            this.UsageCPU.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.UsageCPU.AutoSize = true;
            this.UsageCPU.Checked = true;
            this.UsageCPU.CheckState = System.Windows.Forms.CheckState.Checked;
            this.UsageCPU.Location = new System.Drawing.Point(7, 3);
            this.UsageCPU.Name = "UsageCPU";
            this.UsageCPU.Size = new System.Drawing.Size(240, 27);
            this.UsageCPU.TabIndex = 0;
            this.UsageCPU.Text = "% загруженности процессора";
            this.UsageCPU.UseVisualStyleBackColor = true;
            this.UsageCPU.CheckedChanged += new System.EventHandler(this.CounterUsageCPU_CheckedChanged);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(461, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 23);
            this.label1.TabIndex = 6;
            this.label1.Text = "Время:";
            // 
            // MaxTime
            // 
            this.MaxTime.Font = new System.Drawing.Font("Jost", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MaxTime.Location = new System.Drawing.Point(518, 40);
            this.MaxTime.Name = "MaxTime";
            this.MaxTime.Size = new System.Drawing.Size(49, 26);
            this.MaxTime.TabIndex = 7;
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
            // PerformanceCPU
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.PerformanceChart);
            this.Controls.Add(this.PanelSeries);
            this.Name = "PerformanceCPU";
            this.Size = new System.Drawing.Size(612, 416);
            ((System.ComponentModel.ISupportInitialize)(this.PerformanceChart)).EndInit();
            this.PanelSeries.ResumeLayout(false);
            this.PanelSeries.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart PerformanceChart;
        private System.Windows.Forms.Panel PanelSeries;
        private System.Windows.Forms.CheckBox PrivilegedModeCPU;
        private System.Windows.Forms.CheckBox IdleCPU;
        private System.Windows.Forms.CheckBox UsageCPU;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ButtonStart;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox MaxTime;
    }
}
