
namespace OperatingSystemProject
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btn_ram = new System.Windows.Forms.Button();
            this.txt_ram = new System.Windows.Forms.TextBox();
            this.btn_systemResource = new System.Windows.Forms.Button();
            this.txt_pcInfo = new System.Windows.Forms.TextBox();
            this.txt_hdd = new System.Windows.Forms.TextBox();
            this.txt_cpu = new System.Windows.Forms.TextBox();
            this.btn_pcInfo = new System.Windows.Forms.Button();
            this.btn_hdd = new System.Windows.Forms.Button();
            this.btn_cpu = new System.Windows.Forms.Button();
            this.lbl_baslik = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_ram
            // 
            this.btn_ram.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_ram.BackgroundImage")));
            this.btn_ram.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_ram.Font = new System.Drawing.Font("Times New Roman", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_ram.ForeColor = System.Drawing.Color.White;
            this.btn_ram.Location = new System.Drawing.Point(155, 144);
            this.btn_ram.Name = "btn_ram";
            this.btn_ram.Size = new System.Drawing.Size(175, 70);
            this.btn_ram.TabIndex = 2;
            this.btn_ram.Text = "RAM";
            this.btn_ram.UseVisualStyleBackColor = true;
            this.btn_ram.Click += new System.EventHandler(this.btn_ram_Click);
            // 
            // txt_ram
            // 
            this.txt_ram.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txt_ram.ForeColor = System.Drawing.Color.Black;
            this.txt_ram.Location = new System.Drawing.Point(360, 144);
            this.txt_ram.Multiline = true;
            this.txt_ram.Name = "txt_ram";
            this.txt_ram.Size = new System.Drawing.Size(500, 70);
            this.txt_ram.TabIndex = 5;
            // 
            // btn_systemResource
            // 
            this.btn_systemResource.BackgroundImage = global::OperatingSystemProject.Properties.Resources.kirmiziŞortli;
            this.btn_systemResource.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_systemResource.Font = new System.Drawing.Font("Times New Roman", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_systemResource.ForeColor = System.Drawing.Color.White;
            this.btn_systemResource.Location = new System.Drawing.Point(695, 544);
            this.btn_systemResource.Name = "btn_systemResource";
            this.btn_systemResource.Size = new System.Drawing.Size(165, 41);
            this.btn_systemResource.TabIndex = 15;
            this.btn_systemResource.Text = "Resource";
            this.btn_systemResource.UseVisualStyleBackColor = true;
            this.btn_systemResource.Click += new System.EventHandler(this.btn_systemResource_Click);
            // 
            // txt_pcInfo
            // 
            this.txt_pcInfo.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txt_pcInfo.Location = new System.Drawing.Point(360, 453);
            this.txt_pcInfo.Multiline = true;
            this.txt_pcInfo.Name = "txt_pcInfo";
            this.txt_pcInfo.Size = new System.Drawing.Size(500, 70);
            this.txt_pcInfo.TabIndex = 14;
            // 
            // txt_hdd
            // 
            this.txt_hdd.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txt_hdd.ForeColor = System.Drawing.Color.Black;
            this.txt_hdd.Location = new System.Drawing.Point(360, 350);
            this.txt_hdd.Multiline = true;
            this.txt_hdd.Name = "txt_hdd";
            this.txt_hdd.Size = new System.Drawing.Size(500, 70);
            this.txt_hdd.TabIndex = 13;
            // 
            // txt_cpu
            // 
            this.txt_cpu.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txt_cpu.Location = new System.Drawing.Point(360, 247);
            this.txt_cpu.Multiline = true;
            this.txt_cpu.Name = "txt_cpu";
            this.txt_cpu.Size = new System.Drawing.Size(500, 70);
            this.txt_cpu.TabIndex = 12;
            // 
            // btn_pcInfo
            // 
            this.btn_pcInfo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_pcInfo.BackgroundImage")));
            this.btn_pcInfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_pcInfo.Font = new System.Drawing.Font("Times New Roman", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_pcInfo.ForeColor = System.Drawing.Color.White;
            this.btn_pcInfo.Location = new System.Drawing.Point(155, 453);
            this.btn_pcInfo.Name = "btn_pcInfo";
            this.btn_pcInfo.Size = new System.Drawing.Size(175, 70);
            this.btn_pcInfo.TabIndex = 11;
            this.btn_pcInfo.Text = "PC INFO";
            this.btn_pcInfo.UseVisualStyleBackColor = true;
            this.btn_pcInfo.Click += new System.EventHandler(this.btn_pcInfo_Click);
            // 
            // btn_hdd
            // 
            this.btn_hdd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_hdd.BackgroundImage")));
            this.btn_hdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_hdd.Font = new System.Drawing.Font("Times New Roman", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_hdd.ForeColor = System.Drawing.Color.White;
            this.btn_hdd.Location = new System.Drawing.Point(155, 350);
            this.btn_hdd.Name = "btn_hdd";
            this.btn_hdd.Size = new System.Drawing.Size(175, 70);
            this.btn_hdd.TabIndex = 10;
            this.btn_hdd.Text = "HDD";
            this.btn_hdd.UseVisualStyleBackColor = true;
            this.btn_hdd.Click += new System.EventHandler(this.btn_hdd_Click);
            // 
            // btn_cpu
            // 
            this.btn_cpu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_cpu.BackgroundImage")));
            this.btn_cpu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_cpu.Font = new System.Drawing.Font("Times New Roman", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_cpu.ForeColor = System.Drawing.Color.White;
            this.btn_cpu.Location = new System.Drawing.Point(155, 247);
            this.btn_cpu.Name = "btn_cpu";
            this.btn_cpu.Size = new System.Drawing.Size(175, 70);
            this.btn_cpu.TabIndex = 9;
            this.btn_cpu.Text = "CPU";
            this.btn_cpu.UseVisualStyleBackColor = true;
            this.btn_cpu.Click += new System.EventHandler(this.btn_cpu_Click);
            // 
            // lbl_baslik
            // 
            this.lbl_baslik.AutoSize = true;
            this.lbl_baslik.BackColor = System.Drawing.Color.Transparent;
            this.lbl_baslik.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_baslik.Font = new System.Drawing.Font("Times New Roman", 22.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_baslik.ForeColor = System.Drawing.Color.White;
            this.lbl_baslik.Location = new System.Drawing.Point(333, 49);
            this.lbl_baslik.Name = "lbl_baslik";
            this.lbl_baslik.Size = new System.Drawing.Size(318, 46);
            this.lbl_baslik.TabIndex = 16;
            this.lbl_baslik.Text = "Source Of PC Info";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::OperatingSystemProject.Properties.Resources.kirmiziŞortli;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1007, 617);
            this.Controls.Add(this.lbl_baslik);
            this.Controls.Add(this.btn_systemResource);
            this.Controls.Add(this.txt_pcInfo);
            this.Controls.Add(this.txt_hdd);
            this.Controls.Add(this.txt_cpu);
            this.Controls.Add(this.btn_pcInfo);
            this.Controls.Add(this.btn_hdd);
            this.Controls.Add(this.btn_cpu);
            this.Controls.Add(this.txt_ram);
            this.Controls.Add(this.btn_ram);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Source of PC Info";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_ram;
        private System.Windows.Forms.TextBox txt_ram;
        private System.Windows.Forms.Button btn_systemResource;
        private System.Windows.Forms.TextBox txt_pcInfo;
        private System.Windows.Forms.TextBox txt_hdd;
        private System.Windows.Forms.TextBox txt_cpu;
        private System.Windows.Forms.Button btn_pcInfo;
        private System.Windows.Forms.Button btn_hdd;
        private System.Windows.Forms.Button btn_cpu;
        private System.Windows.Forms.Label lbl_baslik;
    }
}

