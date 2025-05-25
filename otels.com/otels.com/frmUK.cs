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
    public partial class frmUK : Form
    {
        public frmUK()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(new ProcessStartInfo
            {
                FileName = "https://www.thelondoner.com/exclusive-offers/the-londoner-platinum-programme",
                UseShellExecute = true
            });
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmOtelSıralama frm = new frmOtelSıralama();
            frm.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmUK frm = new frmUK();
            frm.Show();
            this.Hide();
        }

        private void btn_Cikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(new ProcessStartInfo
            {
                FileName = "https://www.doylecollection.com/hotels/the-kensington-hotel?utm_source=google&utm_medium=organic&utm_campaign=google_local_hotel-thekensington",
                UseShellExecute = true
            });
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(new ProcessStartInfo
            {
                FileName = "https://www.thesavoylondon.com/?utm_source=google&utm_medium=GMB?goto=fiche_hotel&code_hotel=A597&merchantid=seo-maps-GB-A597&sourceid=aw-cen&utm_medium=seo+maps&utm_source=google+Maps&utm_campaign=seo+maps&y_source=1_MTIzNjE0NDEtNzE1LWxvY2F0aW9uLndlYnNpdGU=",
                UseShellExecute = true
            });
        }

        private void button3_Click(object sender, EventArgs e)
        {
            fmManchester frm = new fmManchester();
            frm.Show();
            this.Hide();
        }
    }
}
