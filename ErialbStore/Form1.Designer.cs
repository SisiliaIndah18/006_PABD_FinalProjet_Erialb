namespace ErialbStore
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.erialbToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rekapPemesanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rekapPembayaranToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rekapSupplierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(175)))), ((int)(((byte)(143)))));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.erialbToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(468, 47);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // erialbToolStripMenuItem
            // 
            this.erialbToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rekapPemesanToolStripMenuItem,
            this.rekapPembayaranToolStripMenuItem,
            this.rekapSupplierToolStripMenuItem});
            this.erialbToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.erialbToolStripMenuItem.ForeColor = System.Drawing.Color.Maroon;
            this.erialbToolStripMenuItem.Name = "erialbToolStripMenuItem";
            this.erialbToolStripMenuItem.Size = new System.Drawing.Size(224, 43);
            this.erialbToolStripMenuItem.Text = "Erialb Menu";
            this.erialbToolStripMenuItem.Click += new System.EventHandler(this.erialbToolStripMenuItem_Click);
            // 
            // rekapPemesanToolStripMenuItem
            // 
            this.rekapPemesanToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rekapPemesanToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.rekapPemesanToolStripMenuItem.Name = "rekapPemesanToolStripMenuItem";
            this.rekapPemesanToolStripMenuItem.Size = new System.Drawing.Size(291, 30);
            this.rekapPemesanToolStripMenuItem.Text = "Rekap Pemesan";
            this.rekapPemesanToolStripMenuItem.Click += new System.EventHandler(this.rekapPemesanToolStripMenuItem_Click);
            // 
            // rekapPembayaranToolStripMenuItem
            // 
            this.rekapPembayaranToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.rekapPembayaranToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.rekapPembayaranToolStripMenuItem.Name = "rekapPembayaranToolStripMenuItem";
            this.rekapPembayaranToolStripMenuItem.Size = new System.Drawing.Size(291, 30);
            this.rekapPembayaranToolStripMenuItem.Text = "Rekap Pembayaran";
            this.rekapPembayaranToolStripMenuItem.Click += new System.EventHandler(this.rekapPembayaranToolStripMenuItem_Click);
            // 
            // rekapSupplierToolStripMenuItem
            // 
            this.rekapSupplierToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.rekapSupplierToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.rekapSupplierToolStripMenuItem.Name = "rekapSupplierToolStripMenuItem";
            this.rekapSupplierToolStripMenuItem.Size = new System.Drawing.Size(291, 30);
            this.rekapSupplierToolStripMenuItem.Text = "Rekap Supplier";
            this.rekapSupplierToolStripMenuItem.Click += new System.EventHandler(this.rekapSupplierToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(468, 367);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Erialb Store";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem erialbToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rekapPemesanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rekapPembayaranToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rekapSupplierToolStripMenuItem;
    }
}

