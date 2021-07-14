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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void rekapPemesanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormPemesan fpm = new FormPemesan();
            fpm.Show();
            this.Hide();
        }

        private void rekapPembayaranToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormPembayaran fpbyr = new FormPembayaran();
            fpbyr.Show();
            this.Hide();
        }

        private void rekapSupplierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormSupplier fs = new FormSupplier();
            fs.Show();
            this.Hide();
        }

        private void erialbToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            menuLogin.Enabled = false;
        }

        void MenuDisable()
        {
            menuLogin.Enabled = true;
            menuLogout.Enabled = false;
            menuErialb.Enabled = false;
            menuPemesan.Enabled = false;
            menuPembayaran.Enabled = false;
            menuSupplier.Enabled = false;
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormLogin fl = new FormLogin();
            fl.Show();
            this.Hide();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MenuDisable();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void menuOwner_Click(object sender, EventArgs e)
        {

        }
    }
}
