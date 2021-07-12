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
    public partial class FormPemesan : Form
    {
        SqlConnection SqlConnection;
        string ConnectionString;
        public FormPemesan()
        {
            InitializeComponent();
            ConnectionString = "Data Source = DESKTOP-RTLLTRA;" + "database = ErialbStore; User Id = sa; Password = indah18";
            SqlConnection = new SqlConnection(ConnectionString);
        }

        private void FormPemesan_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form1 fm = new Form1();
            fm.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FormPemesan_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            SqlConnection = new SqlConnection(ConnectionString);
            SqlConnection.Open();
            SqlCommand dp = new SqlCommand("insert into Pemesan(ID_Pemesan, Nama_Pemesan, IdLine, Alamat, Jenis_Album, Jumlah_Album) values ('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox5.Text + "','" + comboBox1.Text + "','" + textBox6.Text + "')", SqlConnection);
            dp.ExecuteNonQuery();
            MessageBox.Show("Data Pemesanan Berhasil Disimpan");
            SqlConnection.Close();

            Clear();
        }

        private void Clear()
        {
            this.textBox6.Text = "";
            this.textBox1.Text = "";
            this.textBox2.Text = "";
            this.textBox3.Text = "";
            this.comboBox1.Text = "";
            this.textBox5.Text = "";
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            FormPemesanan fp = new FormPemesanan();
            this.Hide();
            fp.Show();
        }
    }
}
