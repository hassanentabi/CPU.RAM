namespace CPU.RAM3
{
    partial class Frm_Main
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Main));
            this.ProgressCPU = new System.Windows.Forms.ProgressBar();
            this.ProgressRAM = new System.Windows.Forms.ProgressBar();
            this.labCPU = new System.Windows.Forms.Label();
            this.labRAM = new System.Windows.Forms.Label();
            this.labeCPU = new System.Windows.Forms.Label();
            this.labeRAM = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.pCPU = new System.Diagnostics.PerformanceCounter();
            this.pRAM = new System.Diagnostics.PerformanceCounter();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pCPU)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRAM)).BeginInit();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // ProgressCPU
            // 
            this.ProgressCPU.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.ProgressCPU.Location = new System.Drawing.Point(89, 39);
            this.ProgressCPU.Name = "ProgressCPU";
            this.ProgressCPU.Size = new System.Drawing.Size(236, 23);
            this.ProgressCPU.TabIndex = 0;
            // 
            // ProgressRAM
            // 
            this.ProgressRAM.Location = new System.Drawing.Point(89, 74);
            this.ProgressRAM.Name = "ProgressRAM";
            this.ProgressRAM.Size = new System.Drawing.Size(236, 23);
            this.ProgressRAM.TabIndex = 1;
            // 
            // labCPU
            // 
            this.labCPU.AutoSize = true;
            this.labCPU.Location = new System.Drawing.Point(40, 41);
            this.labCPU.Name = "labCPU";
            this.labCPU.Size = new System.Drawing.Size(39, 17);
            this.labCPU.TabIndex = 2;
            this.labCPU.Text = "CPU:";
            // 
            // labRAM
            // 
            this.labRAM.AutoSize = true;
            this.labRAM.Location = new System.Drawing.Point(39, 76);
            this.labRAM.Name = "labRAM";
            this.labRAM.Size = new System.Drawing.Size(40, 17);
            this.labRAM.TabIndex = 2;
            this.labRAM.Text = "RAM:";
            // 
            // labeCPU
            // 
            this.labeCPU.AutoSize = true;
            this.labeCPU.Location = new System.Drawing.Point(337, 43);
            this.labeCPU.Name = "labeCPU";
            this.labeCPU.Size = new System.Drawing.Size(42, 17);
            this.labeCPU.TabIndex = 2;
            this.labeCPU.Text = "0.0%";
            // 
            // labeRAM
            // 
            this.labeRAM.AutoSize = true;
            this.labeRAM.Location = new System.Drawing.Point(337, 79);
            this.labeRAM.Name = "labeRAM";
            this.labeRAM.Size = new System.Drawing.Size(42, 17);
            this.labeRAM.TabIndex = 2;
            this.labeRAM.Text = "0.0%";
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // pCPU
            // 
            this.pCPU.CategoryName = "المعالج";
            this.pCPU.CounterName = "% لوقت المعالج";
            this.pCPU.InstanceName = "_Total";
            // 
            // pRAM
            // 
            this.pRAM.CategoryName = "الذاكرة";
            this.pRAM.CounterName = "% لوحدات البايت المحجوزة قيد الاستخدام";
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.SystemColors.Control;
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(413, 28);
            this.menuStrip.TabIndex = 4;
            this.menuStrip.Text = "menuStrip";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem1});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.aboutToolStripMenuItem.Text = "&Help";
            // 
            // aboutToolStripMenuItem1
            // 
            this.aboutToolStripMenuItem1.Image = global::CPU.RAM3.Properties.Resources.information;
            this.aboutToolStripMenuItem1.Name = "aboutToolStripMenuItem1";
            this.aboutToolStripMenuItem1.Size = new System.Drawing.Size(181, 26);
            this.aboutToolStripMenuItem1.Text = "&About";
            this.aboutToolStripMenuItem1.Click += new System.EventHandler(this.aboutToolStripMenuItem1_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Image = global::CPU.RAM3.Properties.Resources.backspace;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F4)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.exitToolStripMenuItem.Text = "&Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // Frm_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(413, 140);
            this.Controls.Add(this.labeRAM);
            this.Controls.Add(this.labeCPU);
            this.Controls.Add(this.labRAM);
            this.Controls.Add(this.labCPU);
            this.Controls.Add(this.ProgressRAM);
            this.Controls.Add(this.ProgressCPU);
            this.Controls.Add(this.menuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.MaximizeBox = false;
            this.Name = "Frm_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CPU & RAM";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pCPU)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRAM)).EndInit();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar ProgressCPU;
        private System.Windows.Forms.ProgressBar ProgressRAM;
        private System.Windows.Forms.Label labCPU;
        private System.Windows.Forms.Label labRAM;
        private System.Windows.Forms.Label labeCPU;
        private System.Windows.Forms.Label labeRAM;
        private System.Windows.Forms.Timer timer;
        private System.Diagnostics.PerformanceCounter pCPU;
        private System.Diagnostics.PerformanceCounter pRAM;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem1;
    }
}

