using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace otels.com
{
    public partial class frmFransaParis : Form
    {
        public frmFransaParis()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmOtelSıralama frm = new frmOtelSıralama();
            frm.Show();
            this.Hide();
        }

        private void btn_Cikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmFransaParis frm = new frmFransaParis();
            frm.Show();
            this.Hide();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(new ProcessStartInfo
            {
                FileName = "https://www.dorchestercollection.com/paris/le-meurice",
                UseShellExecute = true
            });
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(new ProcessStartInfo
            {
                FileName = "https://www.ritzparis.com/?utm_source=google&utm_medium=organic&utm_campaign=gmb_ritz_paris",
                UseShellExecute = true
            });
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(new ProcessStartInfo
            {
                FileName = "https://www.fourseasons.com/paris/?utm_source=google&utm_medium=organicsearch&utm_campaign=tor-par-hre-mid-seo-na&utm_content=na-na&utm_term=na",
                UseShellExecute = true
            });
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmFransaLyon frm = new frmFransaLyon();
            frm.Show();
            this.Hide();
        }
    }
}
