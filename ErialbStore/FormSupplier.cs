using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ErialbStore
{
    public partial class FormSupplier : Form
    {
        SqlConnection SqlConnection;
        string ConnectionString;
        public FormSupplier()
        {
            InitializeComponent();
            ConnectionString = "Data Source = DESKTOP-RTLLTRA;" + "database = ErialbStore; User Id = sa; Password = indah18";
            SqlConnection = new SqlConnection(ConnectionString);
        }

        private void FormSupplier_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form1 fm = new Form1();
            fm.Show();
            this.Hide();
        }

        private void FormSupplier_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection = new SqlConnection(ConnectionString);
            SqlConnection.Open();
            SqlCommand dp = new SqlCommand("insert into Supplier(ID_Supplier, ID_Pemesan, Nama_Supplier, Pengiriman) " + "values ('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + comboBox1.Text + "')", SqlConnection);
            dp.ExecuteNonQuery();
            MessageBox.Show("Data Supplier Berhasil Disimpan");
            SqlConnection.Close();

            Clear();
        }

        private void Clear()
        {
            this.textBox1.Text = "";
            this.textBox2.Text = "";
            this.textBox3.Text = "";
            this.comboBox1.Text = "";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormListDetail fld = new FormListDetail();
            this.Hide();
            fld.Show();
        }
    }
}
