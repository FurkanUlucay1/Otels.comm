namespace otels.com
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            btn_Cikis = new Button();
            label1 = new Label();
            groupBox1 = new GroupBox();
            txtİsim = new TextBox();
            groupBox2 = new GroupBox();
            txtSoyisim = new TextBox();
            groupBox3 = new GroupBox();
            label2 = new Label();
            txtDogumTarihi = new MaskedTextBox();
            groupBox4 = new GroupBox();
            txtTelefonNumarasi = new MaskedTextBox();
            lblcinsiyet = new GroupBox();
            rbKadın = new RadioButton();
            rbErkek = new RadioButton();
            groupBox6 = new GroupBox();
            txtMailAdresi = new TextBox();
            btnTemizle = new Button();
            btnDevam = new Button();
            panel2 = new Panel();
            label3 = new Label();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            lblcinsiyet.SuspendLayout();
            groupBox6.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DeepSkyBlue;
            panel1.Controls.Add(btn_Cikis);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 61);
            panel1.TabIndex = 0;
            // 
            // btn_Cikis
            // 
            btn_Cikis.BackColor = Color.FromArgb(192, 0, 0);
            btn_Cikis.FlatAppearance.BorderSize = 0;
            btn_Cikis.FlatStyle = FlatStyle.Flat;
            btn_Cikis.ForeColor = Color.White;
            btn_Cikis.Location = new Point(741, 0);
            btn_Cikis.Name = "btn_Cikis";
            btn_Cikis.Size = new Size(59, 65);
            btn_Cikis.TabIndex = 2;
            btn_Cikis.Text = "X";
            btn_Cikis.UseVisualStyleBackColor = false;
            btn_Cikis.Click += btn_Cikis_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.ForeColor = Color.White;
            label1.Location = new Point(13, 9);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(148, 38);
            label1.TabIndex = 1;
            label1.Text = "Otels.com";
            label1.Click += label1_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtİsim);
            groupBox1.Location = new Point(60, 103);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(15, 3, 3, 3);
            groupBox1.Size = new Size(288, 67);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "İsim";
            // 
            // txtİsim
            // 
            txtİsim.BorderStyle = BorderStyle.None;
            txtİsim.Dock = DockStyle.Bottom;
            txtİsim.Location = new Point(15, 32);
            txtİsim.Margin = new Padding(15, 3, 3, 3);
            txtİsim.MaxLength = 30;
            txtİsim.Name = "txtİsim";
            txtİsim.Size = new Size(270, 32);
            txtİsim.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtSoyisim);
            groupBox2.Location = new Point(60, 176);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(15, 3, 3, 3);
            groupBox2.Size = new Size(288, 71);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Soyisim";
            // 
            // txtSoyisim
            // 
            txtSoyisim.BorderStyle = BorderStyle.None;
            txtSoyisim.Dock = DockStyle.Bottom;
            txtSoyisim.Location = new Point(15, 36);
            txtSoyisim.MaxLength = 30;
            txtSoyisim.Name = "txtSoyisim";
            txtSoyisim.Size = new Size(270, 32);
            txtSoyisim.TabIndex = 0;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(label2);
            groupBox3.Controls.Add(txtDogumTarihi);
            groupBox3.Location = new Point(60, 265);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(15, 3, 3, 3);
            groupBox3.Size = new Size(291, 71);
            groupBox3.TabIndex = 3;
            groupBox3.TabStop = false;
            groupBox3.Text = "Doğum Tarihi";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.Location = new Point(190, 13);
            label2.Name = "label2";
            label2.Size = new Size(95, 20);
            label2.TabIndex = 6;
            label2.Text = "(gg.aa.yyyy)";
            // 
            // txtDogumTarihi
            // 
            txtDogumTarihi.BorderStyle = BorderStyle.None;
            txtDogumTarihi.Location = new Point(27, 33);
            txtDogumTarihi.Mask = "00/00/0000";
            txtDogumTarihi.Name = "txtDogumTarihi";
            txtDogumTarihi.Size = new Size(258, 32);
            txtDogumTarihi.TabIndex = 10;
            txtDogumTarihi.ValidatingType = typeof(DateTime);
            txtDogumTarihi.MaskInputRejected += maskedTextBox1_MaskInputRejected;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(txtTelefonNumarasi);
            groupBox4.Location = new Point(418, 265);
            groupBox4.Name = "groupBox4";
            groupBox4.Padding = new Padding(15, 3, 3, 3);
            groupBox4.Size = new Size(291, 71);
            groupBox4.TabIndex = 4;
            groupBox4.TabStop = false;
            groupBox4.Text = "Telefon Numarası";
            // 
            // txtTelefonNumarasi
            // 
            txtTelefonNumarasi.BorderStyle = BorderStyle.None;
            txtTelefonNumarasi.Location = new Point(27, 33);
            txtTelefonNumarasi.Mask = "(999) 000-0000";
            txtTelefonNumarasi.Name = "txtTelefonNumarasi";
            txtTelefonNumarasi.Size = new Size(258, 32);
            txtTelefonNumarasi.TabIndex = 11;
          
            // 
            // lblcinsiyet
            // 
            lblcinsiyet.Controls.Add(rbKadın);
            lblcinsiyet.Controls.Add(rbErkek);
            lblcinsiyet.Location = new Point(418, 103);
            lblcinsiyet.Name = "lblcinsiyet";
            lblcinsiyet.Padding = new Padding(15, 3, 3, 3);
            lblcinsiyet.Size = new Size(288, 67);
            lblcinsiyet.TabIndex = 5;
            lblcinsiyet.TabStop = false;
            lblcinsiyet.Text = "Cinsiyet";
            // 
            // rbKadın
            // 
            rbKadın.AutoSize = true;
            rbKadın.Location = new Point(172, 28);
            rbKadın.Name = "rbKadın";
            rbKadın.Size = new Size(101, 36);
            rbKadın.TabIndex = 1;
            rbKadın.Text = "Kadın";
            rbKadın.UseVisualStyleBackColor = true;
            // 
            // rbErkek
            // 
            rbErkek.AutoSize = true;
            rbErkek.Checked = true;
            rbErkek.Location = new Point(47, 29);
            rbErkek.Name = "rbErkek";
            rbErkek.Size = new Size(97, 36);
            rbErkek.TabIndex = 0;
            rbErkek.TabStop = true;
            rbErkek.Text = "Erkek\r\n";
            rbErkek.UseVisualStyleBackColor = true;
            rbErkek.CheckedChanged += rbErkek_CheckedChanged;
            // 
            // groupBox6
            // 
            groupBox6.Controls.Add(txtMailAdresi);
            groupBox6.Location = new Point(418, 174);
            groupBox6.Name = "groupBox6";
            groupBox6.Padding = new Padding(15, 3, 3, 3);
            groupBox6.Size = new Size(288, 71);
            groupBox6.TabIndex = 6;
            groupBox6.TabStop = false;
            groupBox6.Text = "e-mail adresi";
            // 
            // txtMailAdresi
            // 
            txtMailAdresi.BorderStyle = BorderStyle.None;
            txtMailAdresi.Dock = DockStyle.Bottom;
            txtMailAdresi.Location = new Point(15, 36);
            txtMailAdresi.MaxLength = 50;
            txtMailAdresi.Name = "txtMailAdresi";
            txtMailAdresi.Size = new Size(270, 32);
            txtMailAdresi.TabIndex = 0;
            // 
            // btnTemizle
            // 
            btnTemizle.BackColor = Color.FromArgb(192, 0, 0);
            btnTemizle.FlatStyle = FlatStyle.Flat;
            btnTemizle.ForeColor = Color.White;
            btnTemizle.Location = new Point(54, 354);
            btnTemizle.Name = "btnTemizle";
            btnTemizle.Size = new Size(294, 57);
            btnTemizle.TabIndex = 7;
            btnTemizle.Text = "Temizle";
            btnTemizle.UseVisualStyleBackColor = false;
            btnTemizle.Click += btnTemizle_Click;
            // 
            // btnDevam
            // 
            btnDevam.BackColor = Color.Green;
            btnDevam.FlatStyle = FlatStyle.Flat;
            btnDevam.ForeColor = Color.White;
            btnDevam.Location = new Point(418, 354);
            btnDevam.Name = "btnDevam";
            btnDevam.Size = new Size(294, 57);
            btnDevam.TabIndex = 8;
            btnDevam.Text = "Sonraki Adım\n\r\n\r\n";
            btnDevam.UseVisualStyleBackColor = false;
            btnDevam.Click += btnSonraki_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.DeepSkyBlue;
            panel2.Controls.Add(label3);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 465);
            panel2.Margin = new Padding(4, 3, 4, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(800, 61);
            panel2.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.White;
            label3.Location = new Point(294, 11);
            label3.Name = "label3";
            label3.Size = new Size(198, 32);
            label3.TabIndex = 0;
            label3.Text = "Kişi Kayıt Ekranı";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(14F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 526);
            Controls.Add(panel2);
            Controls.Add(btnDevam);
            Controls.Add(btnTemizle);
            Controls.Add(groupBox6);
            Controls.Add(lblcinsiyet);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(panel1);
            Cursor = Cursors.Hand;
            Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 162);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(5, 4, 5, 4);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Giris";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            lblcinsiyet.ResumeLayout(false);
            lblcinsiyet.PerformLayout();
            groupBox6.ResumeLayout(false);
            groupBox6.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Button btn_Cikis;
        private GroupBox groupBox1;
        private TextBox txtİsim;
        private GroupBox groupBox2;
        private TextBox txtSoyisim;
        private GroupBox groupBox3;
        private GroupBox groupBox4;
        private GroupBox lblcinsiyet;
        private RadioButton rbKadın;
        private RadioButton rbErkek;
        private Label label2;
        private GroupBox groupBox6;
        private TextBox txtMailAdresi;
        private Button btnTemizle;
        
        private Panel panel2;
        private Button btnDevam;
        private Label label3;
        private MaskedTextBox txtDogumTarihi;
        private MaskedTextBox txtTelefonNumarasi;
    }
}
