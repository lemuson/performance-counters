namespace PerformanceCounters.Performance_Pages
{
    partial class PerformanceDISK
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.PerformanceChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.ChartPanel = new System.Windows.Forms.Panel();
            this.PanelSeries = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.MaxTime = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ButtonStart = new System.Windows.Forms.Button();
            this.SpeedReadDISK = new System.Windows.Forms.CheckBox();
            this.ActivityDISK = new System.Windows.Forms.CheckBox();
            this.SpeedWriteDISK = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.PerformanceChart)).BeginInit();
            this.ChartPanel.SuspendLayout();
            this.PanelSeries.SuspendLayout();
            this.SuspendLayout();
            // 
            // PerformanceChart
            // 
            chartArea2.AxisX.Interval = 5D;
            chartArea2.AxisX.Maximum = 60D;
            chartArea2.AxisX.Minimum = 0D;
            chartArea2.Name = "ChartArea1";
            this.PerformanceChart.ChartAreas.Add(chartArea2);
            this.PerformanceChart.Dock = System.Windows.Forms.DockStyle.Fill;
            legend2.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend2.Font = new System.Drawing.Font("Jost", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            legend2.IsTextAutoFit = false;
            legend2.Name = "Legend1";
            this.PerformanceChart.Legends.Add(legend2);
            this.PerformanceChart.Location = new System.Drawing.Point(0, 0);
            this.PerformanceChart.Name = "PerformanceChart";
            this.PerformanceChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            series4.BorderWidth = 3;
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series4.Legend = "Legend1";
            series4.LegendText = "Скорость записи на диск";
            series4.Name = "SpeedWriteDISK";
            series5.BorderWidth = 3;
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series5.Legend = "Legend1";
            series5.LegendText = "Скорость чтения с диска";
            series5.Name = "SpeedReadDISK";
            series6.BorderWidth = 3;
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series6.Legend = "Legend1";
            series6.LegendText = "% активности диска";
            series6.Name = "ActivityDISK";
            this.PerformanceChart.Series.Add(series4);
            this.PerformanceChart.Series.Add(series5);
            this.PerformanceChart.Series.Add(series6);
            this.PerformanceChart.Size = new System.Drawing.Size(610, 311);
            this.PerformanceChart.TabIndex = 3;
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
            this.ChartPanel.TabIndex = 9;
            // 
            // PanelSeries
            // 
            this.PanelSeries.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelSeries.Controls.Add(this.label2);
            this.PanelSeries.Controls.Add(this.MaxTime);
            this.PanelSeries.Controls.Add(this.label1);
            this.PanelSeries.Controls.Add(this.ButtonStart);
            this.PanelSeries.Controls.Add(this.SpeedReadDISK);
            this.PanelSeries.Controls.Add(this.ActivityDISK);
            this.PanelSeries.Controls.Add(this.SpeedWriteDISK);
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
            // SpeedReadDISK
            // 
            this.SpeedReadDISK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.SpeedReadDISK.AutoSize = true;
            this.SpeedReadDISK.Checked = true;
            this.SpeedReadDISK.CheckState = System.Windows.Forms.CheckState.Checked;
            this.SpeedReadDISK.Location = new System.Drawing.Point(7, 36);
            this.SpeedReadDISK.Name = "SpeedReadDISK";
            this.SpeedReadDISK.Size = new System.Drawing.Size(205, 27);
            this.SpeedReadDISK.TabIndex = 4;
            this.SpeedReadDISK.Text = "Скорость чтения с диска";
            this.SpeedReadDISK.UseVisualStyleBackColor = true;
            this.SpeedReadDISK.CheckedChanged += new System.EventHandler(this.SpeedReadDISK_CheckedChanged);
            // 
            // ActivityDISK
            // 
            this.ActivityDISK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ActivityDISK.AutoSize = true;
            this.ActivityDISK.Checked = true;
            this.ActivityDISK.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ActivityDISK.Location = new System.Drawing.Point(7, 69);
            this.ActivityDISK.Name = "ActivityDISK";
            this.ActivityDISK.Size = new System.Drawing.Size(167, 27);
            this.ActivityDISK.TabIndex = 3;
            this.ActivityDISK.Text = "% активности диска";
            this.ActivityDISK.UseVisualStyleBackColor = true;
            this.ActivityDISK.CheckedChanged += new System.EventHandler(this.ActivityDISK_CheckedChanged);
            // 
            // SpeedWriteDISK
            // 
            this.SpeedWriteDISK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.SpeedWriteDISK.AutoSize = true;
            this.SpeedWriteDISK.Checked = true;
            this.SpeedWriteDISK.CheckState = System.Windows.Forms.CheckState.Checked;
            this.SpeedWriteDISK.Location = new System.Drawing.Point(7, 3);
            this.SpeedWriteDISK.Name = "SpeedWriteDISK";
            this.SpeedWriteDISK.Size = new System.Drawing.Size(210, 27);
            this.SpeedWriteDISK.TabIndex = 0;
            this.SpeedWriteDISK.Text = "Скорость записи на диск";
            this.SpeedWriteDISK.UseVisualStyleBackColor = true;
            this.SpeedWriteDISK.CheckedChanged += new System.EventHandler(this.SpeedWriteDISK_CheckedChanged);
            // 
            // PerformanceDISK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ChartPanel);
            this.Name = "PerformanceDISK";
            this.Size = new System.Drawing.Size(612, 416);
            ((System.ComponentModel.ISupportInitialize)(this.PerformanceChart)).EndInit();
            this.ChartPanel.ResumeLayout(false);
            this.PanelSeries.ResumeLayout(false);
            this.PanelSeries.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart PerformanceChart;
        private System.Windows.Forms.Panel ChartPanel;
        private System.Windows.Forms.Panel PanelSeries;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox MaxTime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ButtonStart;
        private System.Windows.Forms.CheckBox SpeedReadDISK;
        private System.Windows.Forms.CheckBox ActivityDISK;
        private System.Windows.Forms.CheckBox SpeedWriteDISK;
    }
}
