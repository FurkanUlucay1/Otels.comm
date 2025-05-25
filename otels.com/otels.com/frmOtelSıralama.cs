using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace otels.com
{
    public partial class frmOtelSıralama : Form
    {
        public frmOtelSıralama()
        {
            InitializeComponent();
        }

        private void btn_Cikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnOncekiAdim_Click(object sender, EventArgs e)
        {
            GirisSayfasi frm = new GirisSayfasi();
            frm.ShowDialog();
            this.Hide();

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnAmerica_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnEngland_Click(object sender, EventArgs e)
        {
            frmUK frm = new frmUK();
            frm.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Türkiye_Oteller frm = new Türkiye_Oteller();
            frm.Show();
            this.Hide();


        }

        private void btnAmerica_Click_1(object sender, EventArgs e)
        {
            frmAbdOteller frm = new frmAbdOteller();
            frm.Show();
            this.Hide();

        }

        private void btnFrance_Click(object sender, EventArgs e)
        {
            frmFransaParis frm = new frmFransaParis();
            frm.Show();
            this.Hide();
        }
    }
}
