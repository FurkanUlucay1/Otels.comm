namespace otels.com
{
    partial class frmKisiKayit
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            btn_Cikis = new Button();
            label1 = new Label();
            panel2 = new Panel();
            label2 = new Label();
            btnOncekiAdim = new Button();
            groupBox1 = new GroupBox();
            txtKullaniciAdi = new TextBox();
            groupBox2 = new GroupBox();
            txtSifre = new TextBox();
            groupBox3 = new GroupBox();
            txtSifreTekrar = new TextBox();
            btnTamamla = new Button();
            checkBox1 = new CheckBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
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
            panel1.TabIndex = 1;
            // 
            // btn_Cikis
            // 
            btn_Cikis.BackColor = Color.FromArgb(192, 0, 0);
            btn_Cikis.Cursor = Cursors.Hand;
            btn_Cikis.FlatAppearance.BorderSize = 0;
            btn_Cikis.FlatStyle = FlatStyle.Flat;
            btn_Cikis.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 162);
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
            label1.Location = new Point(13, 12);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(148, 38);
            label1.TabIndex = 1;
            label1.Text = "Otels.com";

            // 
            // panel2
            // 
            panel2.BackColor = Color.DeepSkyBlue;
            panel2.Controls.Add(label2);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 465);
            panel2.Margin = new Padding(4, 3, 4, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(800, 61);
            panel2.TabIndex = 2;

            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.ForeColor = Color.White;
            label2.Location = new Point(217, 17);
            label2.Name = "label2";
            label2.Size = new Size(349, 35);
            label2.TabIndex = 3;
            label2.Text = "Kişi Kayıt Tamamlama Ekranı";

            // 
            // btnOncekiAdim
            // 
            btnOncekiAdim.BackColor = Color.FromArgb(192, 0, 0);
            btnOncekiAdim.Cursor = Cursors.Hand;
            btnOncekiAdim.FlatStyle = FlatStyle.Flat;
            btnOncekiAdim.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnOncekiAdim.ForeColor = Color.White;
            btnOncekiAdim.Location = new Point(77, 363);
            btnOncekiAdim.Name = "btnOncekiAdim";
            btnOncekiAdim.Size = new Size(288, 60);
            btnOncekiAdim.TabIndex = 3;
            btnOncekiAdim.Text = "Geri Dön";
            btnOncekiAdim.UseVisualStyleBackColor = false;
            btnOncekiAdim.Click += button1_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtKullaniciAdi);
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            groupBox1.Location = new Point(253, 82);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(15, 3, 3, 3);
            groupBox1.Size = new Size(288, 70);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Kullanıcı Adı";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // txtKullaniciAdi
            // 
            txtKullaniciAdi.BorderStyle = BorderStyle.None;
            txtKullaniciAdi.Dock = DockStyle.Bottom;
            txtKullaniciAdi.Location = new Point(15, 40);
            txtKullaniciAdi.Margin = new Padding(15, 3, 3, 3);
            txtKullaniciAdi.MaxLength = 50;
            txtKullaniciAdi.Name = "txtKullaniciAdi";
            txtKullaniciAdi.Size = new Size(270, 27);
            txtKullaniciAdi.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtSifre);
            groupBox2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            groupBox2.Location = new Point(253, 158);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(15, 3, 3, 3);
            groupBox2.Size = new Size(288, 70);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            groupBox2.Text = "Şifre";
            // 
            // txtSifre
            // 
            txtSifre.BorderStyle = BorderStyle.None;
            txtSifre.Dock = DockStyle.Bottom;
            txtSifre.Location = new Point(15, 40);
            txtSifre.Margin = new Padding(15, 3, 3, 3);
            txtSifre.MaxLength = 50;
            txtSifre.Name = "txtSifre";
            txtSifre.Size = new Size(270, 27);
            txtSifre.TabIndex = 0;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(txtSifreTekrar);
            groupBox3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            groupBox3.Location = new Point(253, 234);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(15, 3, 3, 3);
            groupBox3.Size = new Size(288, 70);
            groupBox3.TabIndex = 6;
            groupBox3.TabStop = false;
            groupBox3.Text = "Şifre Tekrar";
            groupBox3.Enter += groupBox3_Enter;
            // 
            // txtSifreTekrar
            // 
            txtSifreTekrar.BorderStyle = BorderStyle.None;
            txtSifreTekrar.Dock = DockStyle.Bottom;
            txtSifreTekrar.Location = new Point(15, 40);
            txtSifreTekrar.Margin = new Padding(15, 3, 3, 3);
            txtSifreTekrar.MaxLength = 50;
            txtSifreTekrar.Name = "txtSifreTekrar";
            txtSifreTekrar.Size = new Size(270, 27);
            txtSifreTekrar.TabIndex = 0;
            // 
            // btnTamamla
            // 
            btnTamamla.BackColor = Color.Green;
            btnTamamla.Cursor = Cursors.Hand;
            btnTamamla.FlatStyle = FlatStyle.Flat;
            btnTamamla.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnTamamla.ForeColor = Color.White;
            btnTamamla.Location = new Point(424, 363);
            btnTamamla.Name = "btnTamamla";
            btnTamamla.Size = new Size(288, 60);
            btnTamamla.TabIndex = 9;
            btnTamamla.Text = "Tamamla\r\n\r\n\r\n";
            btnTamamla.UseVisualStyleBackColor = false;
            btnTamamla.Click += btnDevam_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            checkBox1.Location = new Point(171, 310);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(457, 32);
            checkBox1.TabIndex = 10;
            checkBox1.Text = "Kullanıcı Sözleşmesini Okudum Onaylıyorum";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // frmKisiKayit
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 526);
            Controls.Add(checkBox1);
            Controls.Add(btnTamamla);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(btnOncekiAdim);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmKisiKayit";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmKisiKayit";
            Load += frmKisiKayit_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button btn_Cikis;
        private Label label1;
        private Panel panel2;
        private Label label2;
        private Button btnOncekiAdim;
        private GroupBox groupBox1;
        private TextBox txtKullaniciAdi;
        private GroupBox groupBox2;
        private TextBox txtSifre;
        private GroupBox groupBox3;
        private TextBox txtSifreTekrar;
        private Button btnTamamla;
        private CheckBox checkBox1;
    }
}