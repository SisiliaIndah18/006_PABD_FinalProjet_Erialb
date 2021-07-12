using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ErialbStore
{
    public partial class FormPemesanan : Form
    {
        public FormPemesanan()
        {
            InitializeComponent();
        }

        private void FormPemesanan_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'erialbStoreDataSet3.Pemesan' table. You can move, or remove it, as needed.
            this.pemesanTableAdapter1.Fill(this.erialbStoreDataSet3.Pemesan);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormPemesan fp = new FormPemesan();
            this.Hide();
            fp.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            FormDetailPemesanan fdp = new FormDetailPemesanan();
            this.Hide();
            fdp.label1.Text = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
            fdp.label2.Text = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
            fdp.label3.Text = this.dataGridView1.CurrentRow.Cells[2].Value.ToString();
            fdp.label4.Text = this.dataGridView1.CurrentRow.Cells[3].Value.ToString();
            fdp.label5.Text = this.dataGridView1.CurrentRow.Cells[4].Value.ToString();
            fdp.label6.Text = this.dataGridView1.CurrentRow.Cells[5].Value.ToString();
            fdp.Show();
        }
    }
}
