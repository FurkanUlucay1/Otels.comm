namespace otels.com
{
    partial class GirisSayfasi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GirisSayfasi));
            panel2 = new Panel();
            label2 = new Label();
            panel1 = new Panel();
            btn_Cikis = new Button();
            label1 = new Label();
            btnKayitSayfasi = new Button();
            btnGirisSayfasi = new Button();
            panelGaleri = new Panel();
            pictureBox1 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            panelGaleri.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
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
            panel2.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.ForeColor = Color.White;
            label2.Location = new Point(214, 15);
            label2.Name = "label2";
            label2.Size = new Size(327, 37);
            label2.TabIndex = 3;
            label2.Text = "Otels.com'a Hoşgeldiniz\n";
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
            panel1.TabIndex = 4;
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
            btn_Cikis.Size = new Size(59, 61);
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
            // btnKayitSayfasi
            // 
            btnKayitSayfasi.BackColor = Color.FromArgb(40, 167, 69);
            btnKayitSayfasi.FlatStyle = FlatStyle.Flat;
            btnKayitSayfasi.ForeColor = Color.White;
            btnKayitSayfasi.Location = new Point(426, 131);
            btnKayitSayfasi.Name = "btnKayitSayfasi";
            btnKayitSayfasi.Size = new Size(288, 66);
            btnKayitSayfasi.TabIndex = 5;
            btnKayitSayfasi.Text = "Kaydol";
            btnKayitSayfasi.UseVisualStyleBackColor = false;
            btnKayitSayfasi.Click += btnKayitSayfasi_Click;
            // 
            // btnGirisSayfasi
            // 
            btnGirisSayfasi.BackColor = Color.DodgerBlue;
            btnGirisSayfasi.Cursor = Cursors.Hand;
            btnGirisSayfasi.FlatStyle = FlatStyle.Flat;
            btnGirisSayfasi.ForeColor = Color.White;
            btnGirisSayfasi.Location = new Point(84, 131);
            btnGirisSayfasi.Name = "btnGirisSayfasi";
            btnGirisSayfasi.Size = new Size(288, 66);
            btnGirisSayfasi.TabIndex = 6;
            btnGirisSayfasi.Text = "GİRİŞ YAP";
            btnGirisSayfasi.UseVisualStyleBackColor = false;
            btnGirisSayfasi.Click += button2_Click;
            // 
            // panelGaleri
            // 
            panelGaleri.AutoScroll = true;
            panelGaleri.BackColor = Color.LightGray;
            panelGaleri.Controls.Add(pictureBox1);
            panelGaleri.Controls.Add(pictureBox3);
            panelGaleri.Controls.Add(pictureBox2);
            panelGaleri.Location = new Point(101, 257);
            panelGaleri.Name = "panelGaleri";
            panelGaleri.Size = new Size(600, 150);
            panelGaleri.TabIndex = 9;
            panelGaleri.Paint += panel3_Paint;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(201, 150);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click_2;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(400, 0);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(200, 150);
            pictureBox3.TabIndex = 2;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(200, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(200, 150);
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // GirisSayfasi
            // 
            AutoScaleDimensions = new SizeF(12F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 526);
            Controls.Add(panelGaleri);
            Controls.Add(btnGirisSayfasi);
            Controls.Add(btnKayitSayfasi);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "GirisSayfasi";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "GirisSayfasi";
            Load += GirisSayfasi_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panelGaleri.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private Label label2;
        private Panel panel1;
        private Button btn_Cikis;
        private Label label1;
        private Button btnKayitSayfasi;
        private Button btnGirisSayfasi;
        private Panel panelGaleri;
        private PictureBox pictureBox1;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
    }
}