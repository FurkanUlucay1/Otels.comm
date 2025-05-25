using System.Data;
using Microsoft.Data.SqlClient;



namespace otels.com
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_Cikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        SqlConnection conn = new SqlConnection("Server=.;Database=OtelsDB;User Id=sa;Password=1234;TrustServerCertificate=True;");



        private void btnSonraki_Click(object sender, EventArgs e)
        {
            try
            {
                List<string> eksikAlanlar = new List<string>();
                if (string.IsNullOrWhiteSpace(txtÝsim.Text)) eksikAlanlar.Add("Ýsim");
                if (string.IsNullOrWhiteSpace(txtSoyisim.Text)) eksikAlanlar.Add("Soyisim");
                if (string.IsNullOrWhiteSpace(txtMailAdresi.Text)) eksikAlanlar.Add("Mail Adresi");

                if (eksikAlanlar.Count > 0)
                {
                    string mesaj = "Lütfen aþaðýdaki alanlarý doldurun:\n- " + string.Join("\n- ", eksikAlanlar);
                    MessageBox.Show(mesaj, "Eksik Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int yeniKisiId = -1;

                using (SqlConnection baglanti = new SqlConnection(
                    "Data Source=DESKTOP-JJB71N2\\MSSQLSERVER01;Initial Catalog=Otels.comVT;Integrated Security=True;TrustServerCertificate=True;"))
                {
                    baglanti.Open();

                    bool cinsiyet = rbErkek.Checked;

                    using (SqlCommand komut = new SqlCommand(@"
                INSERT INTO Tbl_Kisiler 
                (Ýsim, Soyisim, MailAdresi, DogumTarihi, TelefonNumarasi, Cinsiyet) 
                VALUES 
                (@isim, @soyisim, @mail, @dogum, @telefon, @cinsiyet);
                SELECT SCOPE_IDENTITY();", baglanti))
                    {
                        komut.Parameters.AddWithValue("@isim", txtÝsim.Text.Trim());
                        komut.Parameters.AddWithValue("@soyisim", txtSoyisim.Text.Trim());
                        komut.Parameters.AddWithValue("@mail", txtMailAdresi.Text.Trim());

                        if (DateTime.TryParse(txtDogumTarihi.Text, out DateTime dogumTarihi))
                        {
                            komut.Parameters.AddWithValue("@dogum", dogumTarihi);
                        }
                        else
                        {
                            MessageBox.Show("Doðum tarihi geçersiz.");
                            return;
                        }

                        komut.Parameters.AddWithValue("@telefon", txtTelefonNumarasi.Text.Trim());
                        komut.Parameters.AddWithValue("@cinsiyet", cinsiyet);

                        object sonuc = komut.ExecuteScalar();
                        if (sonuc != null)
                        {
                            yeniKisiId = Convert.ToInt32(sonuc);
                            MessageBox.Show("Kayýt baþarýyla eklendi. ID: " + yeniKisiId);
                        }
                    }
                }

                // ID'yi parametre olarak frmKisiKayit formuna gönder
                frmKisiKayit frm = new frmKisiKayit(yeniKisiId);
                frm.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluþtu: " + ex.Message);
            }
        }

        private void rbErkek_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            txtÝsim.Text = "";
            txtTelefonNumarasi.Text = "";
            txtSoyisim.Text = "";
            txtMailAdresi.Text = "";
            txtDogumTarihi.Text = "";
            rbErkek.Checked = true;
            rbKadýn.Checked = false;
            txtÝsim.Focus();


        }

        private void txtTelefonNumarasi_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtDogumTarihi_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtDogumTarihi_TextChanged(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void mtxtTelefonNumarasi_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }

}


