using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using Microsoft.Data.SqlTypes;

namespace otels.com
{
    public partial class frmKisiKayit : Form
    {
        private int kisiId;
        public frmKisiKayit(int id)
        {
            kisiId = id;
            InitializeComponent();
        }


         

        private void frmKisiKayit_Load(object sender, EventArgs e)
        {

        }

        private void btn_Cikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();
            this.Hide();

            
              

            


        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnDevam_Click(object sender, EventArgs e)
        {
            if (txtSifre.Text == txtSifreTekrar.Text)
            {
                string sifre = txtSifre.Text.Trim();
                string loginame = txtKullaniciAdi.Text.Trim();

                try
                {
                    using (SqlConnection baglanti = new SqlConnection(
                        "Data Source=DESKTOP-JJB71N2\\MSSQLSERVER01;Initial Catalog=Otels.comVT;Integrated Security=True;TrustServerCertificate=True;"))
                    {
                        baglanti.Open();

                        using (SqlCommand komut = new SqlCommand(@"
                                UPDATE Tbl_Kisiler 
                                SET sifre = @sifre, kullaniciAdi = @loginame
                                WHERE id = @id", baglanti))
                        {
                            komut.Parameters.AddWithValue("@id", kisiId);
                            komut.Parameters.AddWithValue("@sifre", sifre);
                            komut.Parameters.AddWithValue("@loginame", loginame);

                            komut.ExecuteNonQuery();
                            MessageBox.Show("Kayıt başarıyla güncellendi.");
                        }
                    }

                    // Güncelleme başarılıysa sonraki forma geç
                    frmOtelSıralama frm = new frmOtelSıralama();
                    frm.Show();
                    this.Hide();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata oluştu: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Şifreler uyuşmuyor. Lütfen tekrar deneyin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }
    }
}
