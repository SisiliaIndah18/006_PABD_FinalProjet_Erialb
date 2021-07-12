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
    public partial class FormDetailPemesanan : Form
    {
        public FormDetailPemesanan()
        {
            InitializeComponent();
        }

        private void FormDetailPemesanan_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormPemesanan fp = new FormPemesanan();
            this.Hide();
            fp.Show();
        }
    }
}
