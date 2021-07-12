namespace ErialbStore
{
    partial class FormListDetail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormListDetail));
            this.pembayaranBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.erialbStoreDataPembayaran = new ErialbStore.ErialbStoreDataPembayaran();
            this.pemesanBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.erialbStoreDataSet = new ErialbStore.ErialbStoreDataSet();
            this.label1 = new System.Windows.Forms.Label();
            this.pemesanTableAdapter = new ErialbStore.ErialbStoreDataSetTableAdapters.PemesanTableAdapter();
            this.pemesanBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.pemesanBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.pemesanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.iDSupplierDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namaSupplierDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pengirimanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDPemesanDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supplierBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.erialbStoreDataSupplier = new ErialbStore.ErialbStoreDataSupplier();
            this.pembayaranTableAdapter = new ErialbStore.ErialbStoreDataPembayaranTableAdapters.PembayaranTableAdapter();
            this.supplierTableAdapter = new ErialbStore.ErialbStoreDataSupplierTableAdapters.SupplierTableAdapter();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.erialbStorePembayaran = new ErialbStore.ErialbStorePembayaran();
            this.pembayaranBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.pembayaranTableAdapter1 = new ErialbStore.ErialbStorePembayaranTableAdapters.PembayaranTableAdapter();
            this.erialbStoreDataSet1 = new ErialbStore.ErialbStoreDataSet1();
            this.pembayaranBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.pembayaranTableAdapter2 = new ErialbStore.ErialbStoreDataSet1TableAdapters.PembayaranTableAdapter();
            this.erialbStoreDataSet2 = new ErialbStore.ErialbStoreDataSet2();
            this.supplierBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.supplierTableAdapter1 = new ErialbStore.ErialbStoreDataSet2TableAdapters.SupplierTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.listPembayaran = new ErialbStore.ListPembayaran();
            this.pembayaranBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.pembayaranTableAdapter3 = new ErialbStore.ListPembayaranTableAdapters.PembayaranTableAdapter();
            this.kodePembayaranDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDPemesanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.metodePembayaranDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalHargaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.listSupplier = new ErialbStore.ListSupplier();
            this.supplierBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.supplierTableAdapter2 = new ErialbStore.ListSupplierTableAdapters.SupplierTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.pembayaranBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erialbStoreDataPembayaran)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pemesanBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erialbStoreDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pemesanBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pemesanBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pemesanBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erialbStoreDataSupplier)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erialbStorePembayaran)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pembayaranBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erialbStoreDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pembayaranBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erialbStoreDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listPembayaran)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pembayaranBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listSupplier)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // pembayaranBindingSource
            // 
            this.pembayaranBindingSource.DataMember = "Pembayaran";
            this.pembayaranBindingSource.DataSource = this.erialbStoreDataPembayaran;
            // 
            // erialbStoreDataPembayaran
            // 
            this.erialbStoreDataPembayaran.DataSetName = "ErialbStoreDataPembayaran";
            this.erialbStoreDataPembayaran.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label1.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label1.Location = new System.Drawing.Point(277, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 48);
            this.label1.TabIndex = 24;
            this.label1.Text = "ERIALB";
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
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToOrderColumns = true;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDSupplierDataGridViewTextBoxColumn,
            this.namaSupplierDataGridViewTextBoxColumn,
            this.pengirimanDataGridViewTextBoxColumn,
            this.iDPemesanDataGridViewTextBoxColumn1});
            this.dataGridView2.DataSource = this.supplierBindingSource2;
            this.dataGridView2.Location = new System.Drawing.Point(31, 337);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 62;
            this.dataGridView2.RowTemplate.Height = 28;
            this.dataGridView2.Size = new System.Drawing.Size(620, 168);
            this.dataGridView2.TabIndex = 27;
            // 
            // iDSupplierDataGridViewTextBoxColumn
            // 
            this.iDSupplierDataGridViewTextBoxColumn.DataPropertyName = "ID_Supplier";
            this.iDSupplierDataGridViewTextBoxColumn.HeaderText = "ID_Supplier";
            this.iDSupplierDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.iDSupplierDataGridViewTextBoxColumn.Name = "iDSupplierDataGridViewTextBoxColumn";
            this.iDSupplierDataGridViewTextBoxColumn.Width = 150;
            // 
            // namaSupplierDataGridViewTextBoxColumn
            // 
            this.namaSupplierDataGridViewTextBoxColumn.DataPropertyName = "Nama_Supplier";
            this.namaSupplierDataGridViewTextBoxColumn.HeaderText = "Nama_Supplier";
            this.namaSupplierDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.namaSupplierDataGridViewTextBoxColumn.Name = "namaSupplierDataGridViewTextBoxColumn";
            this.namaSupplierDataGridViewTextBoxColumn.Width = 150;
            // 
            // pengirimanDataGridViewTextBoxColumn
            // 
            this.pengirimanDataGridViewTextBoxColumn.DataPropertyName = "Pengiriman";
            this.pengirimanDataGridViewTextBoxColumn.HeaderText = "Pengiriman";
            this.pengirimanDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.pengirimanDataGridViewTextBoxColumn.Name = "pengirimanDataGridViewTextBoxColumn";
            this.pengirimanDataGridViewTextBoxColumn.Width = 150;
            // 
            // iDPemesanDataGridViewTextBoxColumn1
            // 
            this.iDPemesanDataGridViewTextBoxColumn1.DataPropertyName = "ID_Pemesan";
            this.iDPemesanDataGridViewTextBoxColumn1.HeaderText = "ID_Pemesan";
            this.iDPemesanDataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.iDPemesanDataGridViewTextBoxColumn1.Name = "iDPemesanDataGridViewTextBoxColumn1";
            this.iDPemesanDataGridViewTextBoxColumn1.Width = 150;
            // 
            // supplierBindingSource
            // 
            this.supplierBindingSource.DataMember = "Supplier";
            this.supplierBindingSource.DataSource = this.erialbStoreDataSupplier;
            // 
            // erialbStoreDataSupplier
            // 
            this.erialbStoreDataSupplier.DataSetName = "ErialbStoreDataSupplier";
            this.erialbStoreDataSupplier.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pembayaranTableAdapter
            // 
            this.pembayaranTableAdapter.ClearBeforeFill = true;
            // 
            // supplierTableAdapter
            // 
            this.supplierTableAdapter.ClearBeforeFill = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.SaddleBrown;
            this.label2.Font = new System.Drawing.Font("MV Boli", 12F);
            this.label2.ForeColor = System.Drawing.Color.SeaShell;
            this.label2.Location = new System.Drawing.Point(68, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 26);
            this.label2.TabIndex = 28;
            this.label2.Text = "List Pembayaran";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.SaddleBrown;
            this.label3.Font = new System.Drawing.Font("MV Boli", 12F);
            this.label3.ForeColor = System.Drawing.Color.SeaShell;
            this.label3.Location = new System.Drawing.Point(68, 305);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 26);
            this.label3.TabIndex = 29;
            this.label3.Text = "List Supplier";
            // 
            // erialbStorePembayaran
            // 
            this.erialbStorePembayaran.DataSetName = "ErialbStorePembayaran";
            this.erialbStorePembayaran.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pembayaranBindingSource1
            // 
            this.pembayaranBindingSource1.DataMember = "Pembayaran";
            this.pembayaranBindingSource1.DataSource = this.erialbStorePembayaran;
            // 
            // pembayaranTableAdapter1
            // 
            this.pembayaranTableAdapter1.ClearBeforeFill = true;
            // 
            // erialbStoreDataSet1
            // 
            this.erialbStoreDataSet1.DataSetName = "ErialbStoreDataSet1";
            this.erialbStoreDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pembayaranBindingSource2
            // 
            this.pembayaranBindingSource2.DataMember = "Pembayaran";
            this.pembayaranBindingSource2.DataSource = this.erialbStoreDataSet1;
            // 
            // pembayaranTableAdapter2
            // 
            this.pembayaranTableAdapter2.ClearBeforeFill = true;
            // 
            // erialbStoreDataSet2
            // 
            this.erialbStoreDataSet2.DataSetName = "ErialbStoreDataSet2";
            this.erialbStoreDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // supplierBindingSource1
            // 
            this.supplierBindingSource1.DataMember = "Supplier";
            this.supplierBindingSource1.DataSource = this.erialbStoreDataSet2;
            // 
            // supplierTableAdapter1
            // 
            this.supplierTableAdapter1.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.kodePembayaranDataGridViewTextBoxColumn,
            this.iDPemesanDataGridViewTextBoxColumn,
            this.metodePembayaranDataGridViewTextBoxColumn,
            this.totalHargaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.pembayaranBindingSource3;
            this.dataGridView1.Location = new System.Drawing.Point(31, 131);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(620, 150);
            this.dataGridView1.TabIndex = 30;
            // 
            // listPembayaran
            // 
            this.listPembayaran.DataSetName = "ListPembayaran";
            this.listPembayaran.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pembayaranBindingSource3
            // 
            this.pembayaranBindingSource3.DataMember = "Pembayaran";
            this.pembayaranBindingSource3.DataSource = this.listPembayaran;
            // 
            // pembayaranTableAdapter3
            // 
            this.pembayaranTableAdapter3.ClearBeforeFill = true;
            // 
            // kodePembayaranDataGridViewTextBoxColumn
            // 
            this.kodePembayaranDataGridViewTextBoxColumn.DataPropertyName = "Kode_Pembayaran";
            this.kodePembayaranDataGridViewTextBoxColumn.HeaderText = "Kode_Pembayaran";
            this.kodePembayaranDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.kodePembayaranDataGridViewTextBoxColumn.Name = "kodePembayaranDataGridViewTextBoxColumn";
            this.kodePembayaranDataGridViewTextBoxColumn.Width = 125;
            // 
            // iDPemesanDataGridViewTextBoxColumn
            // 
            this.iDPemesanDataGridViewTextBoxColumn.DataPropertyName = "ID_Pemesan";
            this.iDPemesanDataGridViewTextBoxColumn.HeaderText = "ID_Pemesan";
            this.iDPemesanDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDPemesanDataGridViewTextBoxColumn.Name = "iDPemesanDataGridViewTextBoxColumn";
            this.iDPemesanDataGridViewTextBoxColumn.Width = 125;
            // 
            // metodePembayaranDataGridViewTextBoxColumn
            // 
            this.metodePembayaranDataGridViewTextBoxColumn.DataPropertyName = "Metode_Pembayaran";
            this.metodePembayaranDataGridViewTextBoxColumn.HeaderText = "Metode_Pembayaran";
            this.metodePembayaranDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.metodePembayaranDataGridViewTextBoxColumn.Name = "metodePembayaranDataGridViewTextBoxColumn";
            this.metodePembayaranDataGridViewTextBoxColumn.Width = 125;
            // 
            // totalHargaDataGridViewTextBoxColumn
            // 
            this.totalHargaDataGridViewTextBoxColumn.DataPropertyName = "Total_Harga";
            this.totalHargaDataGridViewTextBoxColumn.HeaderText = "Total_Harga";
            this.totalHargaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.totalHargaDataGridViewTextBoxColumn.Name = "totalHargaDataGridViewTextBoxColumn";
            this.totalHargaDataGridViewTextBoxColumn.Width = 125;
            // 
            // listSupplier
            // 
            this.listSupplier.DataSetName = "ListSupplier";
            this.listSupplier.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // supplierBindingSource2
            // 
            this.supplierBindingSource2.DataMember = "Supplier";
            this.supplierBindingSource2.DataSource = this.listSupplier;
            // 
            // supplierTableAdapter2
            // 
            this.supplierTableAdapter2.ClearBeforeFill = true;
            // 
            // FormListDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(680, 530);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormListDetail";
            this.Text = "List Detail Pembayaran & Supplier";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormListDetail_FormClosed);
            this.Load += new System.EventHandler(this.FormListDetail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pembayaranBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erialbStoreDataPembayaran)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pemesanBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erialbStoreDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pemesanBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pemesanBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pemesanBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erialbStoreDataSupplier)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erialbStorePembayaran)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pembayaranBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erialbStoreDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pembayaranBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erialbStoreDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listPembayaran)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pembayaranBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listSupplier)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource pemesanBindingSource3;
        private ErialbStoreDataSet erialbStoreDataSet;
        private System.Windows.Forms.BindingSource pemesanBindingSource2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource pemesanBindingSource1;
        private System.Windows.Forms.BindingSource pemesanBindingSource;
        private ErialbStoreDataSetTableAdapters.PemesanTableAdapter pemesanTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView2;
        private ErialbStoreDataPembayaran erialbStoreDataPembayaran;
        private System.Windows.Forms.BindingSource pembayaranBindingSource;
        private ErialbStoreDataPembayaranTableAdapters.PembayaranTableAdapter pembayaranTableAdapter;
        private ErialbStoreDataSupplier erialbStoreDataSupplier;
        private System.Windows.Forms.BindingSource supplierBindingSource;
        private ErialbStoreDataSupplierTableAdapters.SupplierTableAdapter supplierTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDSupplierDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namaSupplierDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pengirimanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDPemesanDataGridViewTextBoxColumn1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private ErialbStorePembayaran erialbStorePembayaran;
        private System.Windows.Forms.BindingSource pembayaranBindingSource1;
        private ErialbStorePembayaranTableAdapters.PembayaranTableAdapter pembayaranTableAdapter1;
        private ErialbStoreDataSet1 erialbStoreDataSet1;
        private System.Windows.Forms.BindingSource pembayaranBindingSource2;
        private ErialbStoreDataSet1TableAdapters.PembayaranTableAdapter pembayaranTableAdapter2;
        private ErialbStoreDataSet2 erialbStoreDataSet2;
        private System.Windows.Forms.BindingSource supplierBindingSource1;
        private ErialbStoreDataSet2TableAdapters.SupplierTableAdapter supplierTableAdapter1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private ListPembayaran listPembayaran;
        private System.Windows.Forms.BindingSource pembayaranBindingSource3;
        private ListPembayaranTableAdapters.PembayaranTableAdapter pembayaranTableAdapter3;
        private System.Windows.Forms.DataGridViewTextBoxColumn kodePembayaranDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDPemesanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn metodePembayaranDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalHargaDataGridViewTextBoxColumn;
        private ListSupplier listSupplier;
        private System.Windows.Forms.BindingSource supplierBindingSource2;
        private ListSupplierTableAdapters.SupplierTableAdapter supplierTableAdapter2;
    }
}