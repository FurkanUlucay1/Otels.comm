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
    public partial class frmFransaLyon : Form
    {
        public frmFransaLyon()
        {
            InitializeComponent();
        }

        private void btn_Cikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmOtelSıralama frm = new frmOtelSıralama();
            frm.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmFransaParis frm = new frmFransaParis();
            frm.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmFransaLyon frm = new frmFransaLyon();
            frm.Show();
            this.Hide();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(new ProcessStartInfo
            {
                FileName = "https://www.villaflorentine.com/fr/",
                UseShellExecute = true
            });
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            System.Diagnostics.Process.Start(new ProcessStartInfo
            {
                FileName = "https://www.ihg.com/intercontinental/hotels/gb/en/lyon/lysha/hoteldetail?cm_mmc=GoogleMaps-_-IC-_-FR-_-LYSHA",
                UseShellExecute = true
            });
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(new ProcessStartInfo
            {
                FileName = "https://www.radissonhotels.com/en-us/hotels/radisson-collection-cour-des-loges-lyon?cid=a:se+b:gmb+c:emea+i:local+e:rco+d:ukirwe+h:FRLYSLCL",
                UseShellExecute = true
            });

        }
    }
}
