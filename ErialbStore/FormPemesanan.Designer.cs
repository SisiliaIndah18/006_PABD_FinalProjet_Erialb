namespace ErialbStore
{
    partial class FormPemesanan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPemesanan));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDPemesanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namaPemesanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idLineDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alamatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jenisAlbumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jumlahAlbumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pemesanBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.erialbStoreDataSet3 = new ErialbStore.ErialbStoreDataSet3();
            this.pemesanBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.erialbStoreDataSet = new ErialbStore.ErialbStoreDataSet();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.pemesanTableAdapter = new ErialbStore.ErialbStoreDataSetTableAdapters.PemesanTableAdapter();
            this.pemesanBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.pemesanBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.pemesanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pemesanTableAdapter1 = new ErialbStore.ErialbStoreDataSet3TableAdapters.PemesanTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pemesanBindingSource4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erialbStoreDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pemesanBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erialbStoreDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pemesanBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pemesanBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pemesanBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDPemesanDataGridViewTextBoxColumn,
            this.namaPemesanDataGridViewTextBoxColumn,
            this.idLineDataGridViewTextBoxColumn,
            this.alamatDataGridViewTextBoxColumn,
            this.jenisAlbumDataGridViewTextBoxColumn,
            this.jumlahAlbumDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.pemesanBindingSource4;
            this.dataGridView1.Location = new System.Drawing.Point(11, 102);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(690, 168);
            this.dataGridView1.TabIndex = 21;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // iDPemesanDataGridViewTextBoxColumn
            // 
            this.iDPemesanDataGridViewTextBoxColumn.DataPropertyName = "ID_Pemesan";
            this.iDPemesanDataGridViewTextBoxColumn.HeaderText = "ID_Pemesan";
            this.iDPemesanDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.iDPemesanDataGridViewTextBoxColumn.Name = "iDPemesanDataGridViewTextBoxColumn";
            this.iDPemesanDataGridViewTextBoxColumn.Width = 150;
            // 
            // namaPemesanDataGridViewTextBoxColumn
            // 
            this.namaPemesanDataGridViewTextBoxColumn.DataPropertyName = "Nama_Pemesan";
            this.namaPemesanDataGridViewTextBoxColumn.HeaderText = "Nama_Pemesan";
            this.namaPemesanDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.namaPemesanDataGridViewTextBoxColumn.Name = "namaPemesanDataGridViewTextBoxColumn";
            this.namaPemesanDataGridViewTextBoxColumn.Width = 150;
            // 
            // idLineDataGridViewTextBoxColumn
            // 
            this.idLineDataGridViewTextBoxColumn.DataPropertyName = "IdLine";
            this.idLineDataGridViewTextBoxColumn.HeaderText = "IdLine";
            this.idLineDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.idLineDataGridViewTextBoxColumn.Name = "idLineDataGridViewTextBoxColumn";
            this.idLineDataGridViewTextBoxColumn.Width = 150;
            // 
            // alamatDataGridViewTextBoxColumn
            // 
            this.alamatDataGridViewTextBoxColumn.DataPropertyName = "Alamat";
            this.alamatDataGridViewTextBoxColumn.HeaderText = "Alamat";
            this.alamatDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.alamatDataGridViewTextBoxColumn.Name = "alamatDataGridViewTextBoxColumn";
            this.alamatDataGridViewTextBoxColumn.Width = 150;
            // 
            // jenisAlbumDataGridViewTextBoxColumn
            // 
            this.jenisAlbumDataGridViewTextBoxColumn.DataPropertyName = "Jenis_Album";
            this.jenisAlbumDataGridViewTextBoxColumn.HeaderText = "Jenis_Album";
            this.jenisAlbumDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.jenisAlbumDataGridViewTextBoxColumn.Name = "jenisAlbumDataGridViewTextBoxColumn";
            this.jenisAlbumDataGridViewTextBoxColumn.Width = 150;
            // 
            // jumlahAlbumDataGridViewTextBoxColumn
            // 
            this.jumlahAlbumDataGridViewTextBoxColumn.DataPropertyName = "Jumlah_Album";
            this.jumlahAlbumDataGridViewTextBoxColumn.HeaderText = "Jumlah_Album";
            this.jumlahAlbumDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.jumlahAlbumDataGridViewTextBoxColumn.Name = "jumlahAlbumDataGridViewTextBoxColumn";
            this.jumlahAlbumDataGridViewTextBoxColumn.Width = 150;
            // 
            // pemesanBindingSource4
            // 
            this.pemesanBindingSource4.DataMember = "Pemesan";
            this.pemesanBindingSource4.DataSource = this.erialbStoreDataSet3;
            // 
            // erialbStoreDataSet3
            // 
            this.erialbStoreDataSet3.DataSetName = "ErialbStoreDataSet3";
            this.erialbStoreDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pemesanBindingSource3
            // 
            this.pemesanBindingSource3.DataMember = "Pemesan";
            this.pemesanBindingSource3.DataSource = this.erialbStoreDataSet;
            // 
            // erialbStoreDataSet
            // 
            this.erialbStoreDataSet.DataSetName = "ErialbStoreDataSet";
            this.erialbStoreDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Castellar", 25.8F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(254, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 53);
            this.label1.TabIndex = 20;
            this.label1.Text = "ERIALB";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.button1.Font = new System.Drawing.Font("MV Boli", 10F);
            this.button1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.button1.Location = new System.Drawing.Point(313, 298);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 34);
            this.button1.TabIndex = 23;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pemesanTableAdapter
            // 
            this.pemesanTableAdapter.ClearBeforeFill = true;
            // 
            // pemesanBindingSource2
            // 
            this.pemesanBindingSource2.DataMember = "Pemesan";
            // 
            // pemesanBindingSource1
            // 
            this.pemesanBindingSource1.DataMember = "Pemesan";
            // 
            // pemesanBindingSource
            // 
            this.pemesanBindingSource.DataMember = "Pemesan";
            // 
            // pemesanTableAdapter1
            // 
            this.pemesanTableAdapter1.ClearBeforeFill = true;
            // 
            // FormPemesanan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(711, 360);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormPemesanan";
            this.Text = "Pemesanan";
            this.Load += new System.EventHandler(this.FormPemesanan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pemesanBindingSource4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erialbStoreDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pemesanBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erialbStoreDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pemesanBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pemesanBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pemesanBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource pemesanBindingSource2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource pemesanBindingSource1;
        private System.Windows.Forms.BindingSource pemesanBindingSource;
        private ErialbStoreDataSet erialbStoreDataSet;
        private System.Windows.Forms.BindingSource pemesanBindingSource3;
        private ErialbStoreDataSetTableAdapters.PemesanTableAdapter pemesanTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDPemesanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namaPemesanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idLineDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn alamatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jenisAlbumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jumlahAlbumDataGridViewTextBoxColumn;
        private ErialbStoreDataSet3 erialbStoreDataSet3;
        private System.Windows.Forms.BindingSource pemesanBindingSource4;
        private ErialbStoreDataSet3TableAdapters.PemesanTableAdapter pemesanTableAdapter1;
    }
}