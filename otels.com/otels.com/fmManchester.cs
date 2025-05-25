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
    public partial class fmManchester : Form
    {
        public fmManchester()
        {
            InitializeComponent();
        }

        private void btn_Cikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(new ProcessStartInfo
            {
                FileName = "https://www.treehousehotels.com/manchester?utm_source=google-gbp&utm_medium=organic&utm_campaign=gbp",
                UseShellExecute = true
            });
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(new ProcessStartInfo
            {
                FileName = "https://www.marriott.com/en-us/hotels/mantx-hotel-football-old-trafford-a-tribute-portfolio-hotel/overview/?scid=f2ae0541-1279-4f24-b197-a979c79310b0",
                UseShellExecute = true
            });
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(new ProcessStartInfo
            {
                FileName = "https://www.hotelgotham.co.uk/manchester/?utm_source=mybusiness&utm_medium=organic",
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
    }
}
