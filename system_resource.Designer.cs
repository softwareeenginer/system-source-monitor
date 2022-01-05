
namespace OperatingSystemProject
{
    partial class system_resource
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(system_resource));
            this.lbl_ram = new System.Windows.Forms.Label();
            this.lbl_cpu = new System.Windows.Forms.Label();
            this.lstbox_islemler = new System.Windows.Forms.ListBox();
            this.btn_listele = new System.Windows.Forms.Button();
            this.btn_startAndStop = new System.Windows.Forms.Button();
            this.progressBar_ram = new System.Windows.Forms.ProgressBar();
            this.progressBar_cpu = new System.Windows.Forms.ProgressBar();
            this.lbl_cpuUsage = new System.Windows.Forms.Label();
            this.lbl_ramUsage = new System.Windows.Forms.Label();
            this.lbl_pageName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_ram
            // 
            this.lbl_ram.AutoSize = true;
            this.lbl_ram.BackColor = System.Drawing.Color.Transparent;
            this.lbl_ram.Font = new System.Drawing.Font("Times New Roman", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_ram.ForeColor = System.Drawing.Color.White;
            this.lbl_ram.Location = new System.Drawing.Point(726, 190);
            this.lbl_ram.Name = "lbl_ram";
            this.lbl_ram.Size = new System.Drawing.Size(0, 34);
            this.lbl_ram.TabIndex = 13;
            // 
            // lbl_cpu
            // 
            this.lbl_cpu.AutoSize = true;
            this.lbl_cpu.BackColor = System.Drawing.Color.Transparent;
            this.lbl_cpu.Font = new System.Drawing.Font("Times New Roman", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_cpu.ForeColor = System.Drawing.Color.White;
            this.lbl_cpu.Location = new System.Drawing.Point(726, 126);
            this.lbl_cpu.Name = "lbl_cpu";
            this.lbl_cpu.Size = new System.Drawing.Size(0, 34);
            this.lbl_cpu.TabIndex = 12;
            // 
            // lstbox_islemler
            // 
            this.lstbox_islemler.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lstbox_islemler.FormattingEnabled = true;
            this.lstbox_islemler.ItemHeight = 16;
            this.lstbox_islemler.Location = new System.Drawing.Point(232, 306);
            this.lstbox_islemler.Name = "lstbox_islemler";
            this.lstbox_islemler.Size = new System.Drawing.Size(506, 180);
            this.lstbox_islemler.TabIndex = 11;
            // 
            // btn_listele
            // 
            this.btn_listele.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_listele.BackgroundImage")));
            this.btn_listele.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_listele.Font = new System.Drawing.Font("Times New Roman", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_listele.ForeColor = System.Drawing.Color.White;
            this.btn_listele.Location = new System.Drawing.Point(365, 504);
            this.btn_listele.Name = "btn_listele";
            this.btn_listele.Size = new System.Drawing.Size(240, 41);
            this.btn_listele.TabIndex = 10;
            this.btn_listele.Text = "Runnig Processes";
            this.btn_listele.UseVisualStyleBackColor = true;
            this.btn_listele.Click += new System.EventHandler(this.btn_listele_Click);
            // 
            // btn_startAndStop
            // 
            this.btn_startAndStop.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btn_startAndStop.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_startAndStop.BackgroundImage")));
            this.btn_startAndStop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_startAndStop.Font = new System.Drawing.Font("Times New Roman", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_startAndStop.ForeColor = System.Drawing.Color.White;
            this.btn_startAndStop.Location = new System.Drawing.Point(365, 245);
            this.btn_startAndStop.Name = "btn_startAndStop";
            this.btn_startAndStop.Size = new System.Drawing.Size(240, 41);
            this.btn_startAndStop.TabIndex = 9;
            this.btn_startAndStop.Text = "Start";
            this.btn_startAndStop.UseVisualStyleBackColor = false;
            this.btn_startAndStop.Click += new System.EventHandler(this.btn_startAndStop_Click);
            // 
            // progressBar_ram
            // 
            this.progressBar_ram.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.progressBar_ram.Location = new System.Drawing.Point(259, 191);
            this.progressBar_ram.Name = "progressBar_ram";
            this.progressBar_ram.Size = new System.Drawing.Size(453, 36);
            this.progressBar_ram.TabIndex = 8;
            // 
            // progressBar_cpu
            // 
            this.progressBar_cpu.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.progressBar_cpu.Location = new System.Drawing.Point(259, 123);
            this.progressBar_cpu.Name = "progressBar_cpu";
            this.progressBar_cpu.Size = new System.Drawing.Size(453, 36);
            this.progressBar_cpu.TabIndex = 7;
            // 
            // lbl_cpuUsage
            // 
            this.lbl_cpuUsage.AutoSize = true;
            this.lbl_cpuUsage.BackColor = System.Drawing.Color.Transparent;
            this.lbl_cpuUsage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_cpuUsage.Font = new System.Drawing.Font("Times New Roman", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_cpuUsage.ForeColor = System.Drawing.Color.White;
            this.lbl_cpuUsage.Location = new System.Drawing.Point(68, 123);
            this.lbl_cpuUsage.Name = "lbl_cpuUsage";
            this.lbl_cpuUsage.Size = new System.Drawing.Size(162, 36);
            this.lbl_cpuUsage.TabIndex = 14;
            this.lbl_cpuUsage.Text = "CPU Usage";
            // 
            // lbl_ramUsage
            // 
            this.lbl_ramUsage.AutoSize = true;
            this.lbl_ramUsage.BackColor = System.Drawing.Color.Transparent;
            this.lbl_ramUsage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_ramUsage.Font = new System.Drawing.Font("Times New Roman", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_ramUsage.ForeColor = System.Drawing.Color.White;
            this.lbl_ramUsage.Location = new System.Drawing.Point(61, 191);
            this.lbl_ramUsage.Name = "lbl_ramUsage";
            this.lbl_ramUsage.Size = new System.Drawing.Size(169, 36);
            this.lbl_ramUsage.TabIndex = 15;
            this.lbl_ramUsage.Text = "RAM Usage";
            // 
            // lbl_pageName
            // 
            this.lbl_pageName.AutoSize = true;
            this.lbl_pageName.BackColor = System.Drawing.Color.Transparent;
            this.lbl_pageName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_pageName.Font = new System.Drawing.Font("Times New Roman", 22.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_pageName.ForeColor = System.Drawing.Color.White;
            this.lbl_pageName.Location = new System.Drawing.Point(287, 43);
            this.lbl_pageName.Name = "lbl_pageName";
            this.lbl_pageName.Size = new System.Drawing.Size(397, 46);
            this.lbl_pageName.TabIndex = 16;
            this.lbl_pageName.Text = "System Resource Usage";
            // 
            // system_resource
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::OperatingSystemProject.Properties.Resources.kirmiziŞortli;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(912, 572);
            this.Controls.Add(this.lbl_pageName);
            this.Controls.Add(this.lbl_ramUsage);
            this.Controls.Add(this.lbl_cpuUsage);
            this.Controls.Add(this.lbl_ram);
            this.Controls.Add(this.lbl_cpu);
            this.Controls.Add(this.lstbox_islemler);
            this.Controls.Add(this.btn_listele);
            this.Controls.Add(this.btn_startAndStop);
            this.Controls.Add(this.progressBar_ram);
            this.Controls.Add(this.progressBar_cpu);
            this.MaximizeBox = false;
            this.Name = "system_resource";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "System Resource Usage";
            this.Load += new System.EventHandler(this.system_resource_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_ram;
        private System.Windows.Forms.Label lbl_cpu;
        private System.Windows.Forms.ListBox lstbox_islemler;
        private System.Windows.Forms.Button btn_listele;
        private System.Windows.Forms.Button btn_startAndStop;
        private System.Windows.Forms.ProgressBar progressBar_ram;
        private System.Windows.Forms.ProgressBar progressBar_cpu;
        private System.Windows.Forms.Label lbl_cpuUsage;
        private System.Windows.Forms.Label lbl_ramUsage;
        private System.Windows.Forms.Label lbl_pageName;
    }
}