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
    public partial class FormPembayaran : Form
    {
        SqlConnection SqlConnection;
        string ConnectionString;
        public FormPembayaran()
        {
            InitializeComponent();
            ConnectionString = "Data Source = DESKTOP-RTLLTRA;" + "database = ErialbStore; User Id = sa; Password = indah18";
            SqlConnection = new SqlConnection(ConnectionString);
        }

        private void FormPembayaran_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form1 fm = new Form1();
            fm.Show();
            this.Hide();
        }

        private void FormPembayaran_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection = new SqlConnection(ConnectionString);
            SqlConnection.Open();
            SqlCommand dp = new SqlCommand("insert into Pembayaran(Kode_Pembayaran, ID_Pemesan, Metode_Pembayaran, Total_Harga) " + "values ('" + textBox1.Text + "','" + textBox2.Text + "','" + comboBox1.Text + "','" + textBox4.Text + "')", SqlConnection);
            dp.ExecuteNonQuery();
            MessageBox.Show("Data Pembayaran Berhasil Disimpan");
            SqlConnection.Close();

            Clear();
        }

        private void Clear()
        {
            this.textBox1.Text = "";
            this.textBox2.Text = "";
            this.comboBox1.Text = "";
            this.textBox4.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormListDetail fld = new FormListDetail();
            this.Hide();
            fld.Show();
        }
    }
}
