using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Microsoft.Data.SqlClient;
using Microsoft.IdentityModel.Tokens;

namespace otels.com
{
    public partial class frmGirisYapma : Form
    {
        public frmGirisYapma()
        {
            InitializeComponent();
        }

        private void btnOncekiAdim_Click(object sender, EventArgs e)
        {
            GirisSayfasi frm = new GirisSayfasi();
            frm.Show();
            this.Hide();
        }

        private void btn_Cikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(txtKullaniciAdi.Text.IsNullOrEmpty() || txtSifre.Text.IsNullOrEmpty())
            {
                MessageBox.Show("Eksik Bilgi", "Eksik Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string inputLogin = txtKullaniciAdi.Text.Trim();
                string inputSifre = txtSifre.Text.Trim();

                try
                {
                    string connectionString = "Data Source=DESKTOP-JJB71N2\\MSSQLSERVER01;Initial Catalog=Otels.comVT;Integrated Security=True;TrustServerCertificate=True;";

                    using (SqlConnection baglanti = new SqlConnection(connectionString))
                    {
                        string sorgu = "SELECT COUNT(*) FROM tbl_Kisiler WHERE KullaniciAdi = @loginame AND Sifre = @sifre";

                        using (SqlCommand komut = new SqlCommand(sorgu, baglanti))
                        {
                            komut.Parameters.AddWithValue("@loginame", inputLogin);
                            komut.Parameters.AddWithValue("@sifre", inputSifre);

                            baglanti.Open();
                            int sonuc = (int)komut.ExecuteScalar(); // Sorgudan dönen değer

                            if (sonuc > 0)
                            {
                                frmOtelSıralama frm = new frmOtelSıralama();
                                frm.Show();
                                this.Hide();
                            }
                            else
                            {
                                MessageBox.Show("Yanlış Bilgi", "Yanlış Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }
    }
}
