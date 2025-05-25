namespace otels.com
{
    partial class frmGirisYapma
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGirisYapma));
            panel1 = new Panel();
            btn_Cikis = new Button();
            label1 = new Label();
            panel2 = new Panel();
            label3 = new Label();
            groupBox1 = new GroupBox();
            txtKullaniciAdi = new TextBox();
            groupBox2 = new GroupBox();
            txtSifre = new TextBox();
            button1 = new Button();
            btnOncekiAdim = new Button();
            checkBox1 = new CheckBox();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
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
            btn_Cikis.FlatAppearance.BorderSize = 0;
            btn_Cikis.FlatStyle = FlatStyle.Flat;
            btn_Cikis.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
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
            // 
            // panel2
            // 
            panel2.BackColor = Color.DeepSkyBlue;
            panel2.Controls.Add(label3);
            panel2.Dock = DockStyle.Bottom;
            panel2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            panel2.Location = new Point(0, 465);
            panel2.Margin = new Padding(4, 3, 4, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(800, 61);
            panel2.TabIndex = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label3.ForeColor = Color.White;
            label3.Location = new Point(298, 11);
            label3.Name = "label3";
            label3.Size = new Size(145, 31);
            label3.TabIndex = 0;
            label3.Text = "GİRİŞ YAPIN\r\n";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtKullaniciAdi);
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            groupBox1.Location = new Point(248, 110);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(15, 3, 3, 3);
            groupBox1.Size = new Size(288, 70);
            groupBox1.TabIndex = 11;
            groupBox1.TabStop = false;
            groupBox1.Text = "Kullanıcı Adı";
            // 
            // txtKullaniciAdi
            // 
            txtKullaniciAdi.BackColor = Color.White;
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
            groupBox2.Location = new Point(248, 204);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(15, 3, 3, 3);
            groupBox2.Size = new Size(288, 70);
            groupBox2.TabIndex = 12;
            groupBox2.TabStop = false;
            groupBox2.Text = "Şifre";
            // 
            // txtSifre
            // 
            txtSifre.BackColor = Color.White;
            txtSifre.BorderStyle = BorderStyle.None;
            txtSifre.Dock = DockStyle.Bottom;
            txtSifre.Location = new Point(15, 40);
            txtSifre.Margin = new Padding(15, 3, 3, 3);
            txtSifre.MaxLength = 50;
            txtSifre.Name = "txtSifre";
            txtSifre.Size = new Size(270, 27);
            txtSifre.TabIndex = 0;
            // 
            // button1
            // 
            button1.BackColor = Color.Green;
            button1.Cursor = Cursors.Hand;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button1.ForeColor = Color.White;
            button1.Location = new Point(395, 347);
            button1.Name = "button1";
            button1.Size = new Size(288, 63);
            button1.TabIndex = 13;
            button1.Text = "Giriş Yap";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // btnOncekiAdim
            // 
            btnOncekiAdim.BackColor = Color.FromArgb(192, 0, 0);
            btnOncekiAdim.Cursor = Cursors.Hand;
            btnOncekiAdim.FlatStyle = FlatStyle.Flat;
            btnOncekiAdim.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnOncekiAdim.ForeColor = Color.White;
            btnOncekiAdim.Location = new Point(78, 347);
            btnOncekiAdim.Name = "btnOncekiAdim";
            btnOncekiAdim.Size = new Size(288, 63);
            btnOncekiAdim.TabIndex = 14;
            btnOncekiAdim.Text = "Geri Dön";
            btnOncekiAdim.UseVisualStyleBackColor = false;
            btnOncekiAdim.Click += btnOncekiAdim_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            checkBox1.Location = new Point(278, 297);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(213, 32);
            checkBox1.TabIndex = 15;
            checkBox1.Text = "Ben Robot Değilim";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(578, 110);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(198, 184);
            pictureBox1.TabIndex = 16;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(28, 115);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(198, 179);
            pictureBox2.TabIndex = 17;
            pictureBox2.TabStop = false;
            // 
            // frmGirisYapma
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 526);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(checkBox1);
            Controls.Add(btnOncekiAdim);
            Controls.Add(button1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmGirisYapma";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmGirisYapma";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button btn_Cikis;
        private Label label1;
        private Panel panel2;
        private Label label3;
        private GroupBox groupBox1;
        private TextBox txtKullaniciAdi;
        private GroupBox groupBox2;
        private TextBox txtSifre;
        private Button button1;
        private Button btnOncekiAdim;
        private CheckBox checkBox1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}