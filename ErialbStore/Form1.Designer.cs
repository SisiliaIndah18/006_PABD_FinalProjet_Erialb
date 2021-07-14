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
            this.menuOwner = new System.Windows.Forms.ToolStripMenuItem();
            this.menuLogin = new System.Windows.Forms.ToolStripMenuItem();
            this.menuLogout = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.menuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuErialb = new System.Windows.Forms.ToolStripMenuItem();
            this.menuPemesan = new System.Windows.Forms.ToolStripMenuItem();
            this.menuPembayaran = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSupplier = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(175)))), ((int)(((byte)(143)))));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuOwner,
            this.menuErialb});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(468, 49);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // menuOwner
            // 
            this.menuOwner.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuLogin,
            this.menuLogout,
            this.toolStripMenuItem1,
            this.menuExit});
            this.menuOwner.Font = new System.Drawing.Font("Bradley Hand ITC", 19.8F, System.Drawing.FontStyle.Bold);
            this.menuOwner.ForeColor = System.Drawing.Color.Maroon;
            this.menuOwner.Name = "menuOwner";
            this.menuOwner.Size = new System.Drawing.Size(127, 45);
            this.menuOwner.Text = "Owner";
            this.menuOwner.Click += new System.EventHandler(this.menuOwner_Click);
            // 
            // menuLogin
            // 
            this.menuLogin.Font = new System.Drawing.Font("Bradley Hand ITC", 13.8F, System.Drawing.FontStyle.Bold);
            this.menuLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.menuLogin.Name = "menuLogin";
            this.menuLogin.Size = new System.Drawing.Size(224, 34);
            this.menuLogin.Text = "Login";
            this.menuLogin.Click += new System.EventHandler(this.loginToolStripMenuItem_Click);
            // 
            // menuLogout
            // 
            this.menuLogout.Font = new System.Drawing.Font("Bradley Hand ITC", 13.8F, System.Drawing.FontStyle.Bold);
            this.menuLogout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.menuLogout.Name = "menuLogout";
            this.menuLogout.Size = new System.Drawing.Size(224, 34);
            this.menuLogout.Text = "Logout";
            this.menuLogout.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(221, 6);
            // 
            // menuExit
            // 
            this.menuExit.Font = new System.Drawing.Font("Bradley Hand ITC", 13.8F, System.Drawing.FontStyle.Bold);
            this.menuExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.menuExit.Name = "menuExit";
            this.menuExit.Size = new System.Drawing.Size(224, 34);
            this.menuExit.Text = "Exit";
            this.menuExit.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // menuErialb
            // 
            this.menuErialb.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuPemesan,
            this.menuPembayaran,
            this.menuSupplier});
            this.menuErialb.Font = new System.Drawing.Font("Bradley Hand ITC", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuErialb.ForeColor = System.Drawing.Color.Maroon;
            this.menuErialb.Name = "menuErialb";
            this.menuErialb.Size = new System.Drawing.Size(116, 45);
            this.menuErialb.Text = "Menu";
            this.menuErialb.Click += new System.EventHandler(this.erialbToolStripMenuItem_Click);
            // 
            // menuPemesan
            // 
            this.menuPemesan.Font = new System.Drawing.Font("Bradley Hand ITC", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuPemesan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.menuPemesan.Name = "menuPemesan";
            this.menuPemesan.Size = new System.Drawing.Size(321, 34);
            this.menuPemesan.Text = "Rekap Pemesan";
            this.menuPemesan.Click += new System.EventHandler(this.rekapPemesanToolStripMenuItem_Click);
            // 
            // menuPembayaran
            // 
            this.menuPembayaran.Font = new System.Drawing.Font("Bradley Hand ITC", 13.8F, System.Drawing.FontStyle.Bold);
            this.menuPembayaran.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.menuPembayaran.Name = "menuPembayaran";
            this.menuPembayaran.Size = new System.Drawing.Size(321, 34);
            this.menuPembayaran.Text = "Rekap Pembayaran";
            this.menuPembayaran.Click += new System.EventHandler(this.rekapPembayaranToolStripMenuItem_Click);
            // 
            // menuSupplier
            // 
            this.menuSupplier.Font = new System.Drawing.Font("Bradley Hand ITC", 13.8F, System.Drawing.FontStyle.Bold);
            this.menuSupplier.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.menuSupplier.Name = "menuSupplier";
            this.menuSupplier.Size = new System.Drawing.Size(321, 34);
            this.menuSupplier.Text = "Rekap Supplier";
            this.menuSupplier.Click += new System.EventHandler(this.rekapSupplierToolStripMenuItem_Click);
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
        public System.Windows.Forms.ToolStripMenuItem menuOwner;
        public System.Windows.Forms.ToolStripMenuItem menuLogin;
        public System.Windows.Forms.ToolStripMenuItem menuLogout;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        public System.Windows.Forms.ToolStripMenuItem menuErialb;
        public System.Windows.Forms.ToolStripMenuItem menuPemesan;
        public System.Windows.Forms.ToolStripMenuItem menuPembayaran;
        public System.Windows.Forms.ToolStripMenuItem menuSupplier;
        public System.Windows.Forms.ToolStripMenuItem menuExit;
    }
}

