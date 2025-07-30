namespace PerformanceCounters
{
    partial class MainForm
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

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.BorderFormPanel = new System.Windows.Forms.Panel();
            this.ButtonClose = new System.Windows.Forms.Button();
            this.PerformanceMenu = new System.Windows.Forms.FlowLayoutPanel();
            this.ButtonCPU = new System.Windows.Forms.Button();
            this.ButtonRAM = new System.Windows.Forms.Button();
            this.ButtonDisk = new System.Windows.Forms.Button();
            this.PerformancePanel = new System.Windows.Forms.Panel();
            this.BorderFormPanel.SuspendLayout();
            this.PerformanceMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // BorderFormPanel
            // 
            this.BorderFormPanel.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BorderFormPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BorderFormPanel.Controls.Add(this.ButtonClose);
            this.BorderFormPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.BorderFormPanel.Location = new System.Drawing.Point(0, 0);
            this.BorderFormPanel.Name = "BorderFormPanel";
            this.BorderFormPanel.Size = new System.Drawing.Size(815, 34);
            this.BorderFormPanel.TabIndex = 0;
            this.BorderFormPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BorderFormPanel_MouseDown);
            // 
            // ButtonClose
            // 
            this.ButtonClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.ButtonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonClose.Location = new System.Drawing.Point(779, 0);
            this.ButtonClose.Name = "ButtonClose";
            this.ButtonClose.Size = new System.Drawing.Size(34, 32);
            this.ButtonClose.TabIndex = 0;
            this.ButtonClose.TabStop = false;
            this.ButtonClose.Text = "X";
            this.ButtonClose.UseVisualStyleBackColor = true;
            this.ButtonClose.Click += new System.EventHandler(this.ButtonClose_Click);
            // 
            // PerformanceMenu
            // 
            this.PerformanceMenu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PerformanceMenu.Controls.Add(this.ButtonCPU);
            this.PerformanceMenu.Controls.Add(this.ButtonRAM);
            this.PerformanceMenu.Controls.Add(this.ButtonDisk);
            this.PerformanceMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.PerformanceMenu.Location = new System.Drawing.Point(0, 34);
            this.PerformanceMenu.Name = "PerformanceMenu";
            this.PerformanceMenu.Size = new System.Drawing.Size(203, 416);
            this.PerformanceMenu.TabIndex = 1;
            // 
            // ButtonCPU
            // 
            this.ButtonCPU.Dock = System.Windows.Forms.DockStyle.Top;
            this.ButtonCPU.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonCPU.Font = new System.Drawing.Font("Jost", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonCPU.Location = new System.Drawing.Point(3, 3);
            this.ButtonCPU.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.ButtonCPU.Name = "ButtonCPU";
            this.ButtonCPU.Size = new System.Drawing.Size(197, 48);
            this.ButtonCPU.TabIndex = 0;
            this.ButtonCPU.TabStop = false;
            this.ButtonCPU.Text = "Центральный процессор";
            this.ButtonCPU.UseVisualStyleBackColor = true;
            this.ButtonCPU.Click += new System.EventHandler(this.ButtonCPU_Click);
            // 
            // ButtonRAM
            // 
            this.ButtonRAM.Dock = System.Windows.Forms.DockStyle.Top;
            this.ButtonRAM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonRAM.Font = new System.Drawing.Font("Jost", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonRAM.Location = new System.Drawing.Point(3, 54);
            this.ButtonRAM.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.ButtonRAM.Name = "ButtonRAM";
            this.ButtonRAM.Size = new System.Drawing.Size(197, 48);
            this.ButtonRAM.TabIndex = 1;
            this.ButtonRAM.TabStop = false;
            this.ButtonRAM.Text = "Память";
            this.ButtonRAM.UseVisualStyleBackColor = true;
            this.ButtonRAM.Click += new System.EventHandler(this.ButtonRAM_Click);
            // 
            // ButtonDisk
            // 
            this.ButtonDisk.Dock = System.Windows.Forms.DockStyle.Top;
            this.ButtonDisk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonDisk.Font = new System.Drawing.Font("Jost", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonDisk.Location = new System.Drawing.Point(3, 105);
            this.ButtonDisk.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.ButtonDisk.Name = "ButtonDisk";
            this.ButtonDisk.Size = new System.Drawing.Size(197, 48);
            this.ButtonDisk.TabIndex = 2;
            this.ButtonDisk.TabStop = false;
            this.ButtonDisk.Text = "Диск";
            this.ButtonDisk.UseVisualStyleBackColor = true;
            this.ButtonDisk.Click += new System.EventHandler(this.ButtonGPU_Click);
            // 
            // PerformancePanel
            // 
            this.PerformancePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PerformancePanel.Location = new System.Drawing.Point(203, 34);
            this.PerformancePanel.Name = "PerformancePanel";
            this.PerformancePanel.Size = new System.Drawing.Size(612, 416);
            this.PerformancePanel.TabIndex = 2;
            this.PerformancePanel.ControlAdded += new System.Windows.Forms.ControlEventHandler(this.PerformancePanel_ControlAdded);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 450);
            this.Controls.Add(this.PerformancePanel);
            this.Controls.Add(this.PerformanceMenu);
            this.Controls.Add(this.BorderFormPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.BorderFormPanel.ResumeLayout(false);
            this.PerformanceMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel BorderFormPanel;
        private System.Windows.Forms.Button ButtonClose;
        private System.Windows.Forms.FlowLayoutPanel PerformanceMenu;
        private System.Windows.Forms.Button ButtonCPU;
        private System.Windows.Forms.Button ButtonRAM;
        private System.Windows.Forms.Button ButtonDisk;
        private System.Windows.Forms.Panel PerformancePanel;
    }
}

