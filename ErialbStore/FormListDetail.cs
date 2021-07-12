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
    public partial class FormListDetail : Form
    {
        public FormListDetail()
        {
            InitializeComponent();
        }

        private void FormListDetail_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'listSupplier.Supplier' table. You can move, or remove it, as needed.
            this.supplierTableAdapter2.Fill(this.listSupplier.Supplier);
            // TODO: This line of code loads data into the 'listPembayaran.Pembayaran' table. You can move, or remove it, as needed.
            this.pembayaranTableAdapter3.Fill(this.listPembayaran.Pembayaran);
        }

        private void FormListDetail_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form1 fm = new Form1();
            fm.Show();
            this.Hide();
        }
    }
}
