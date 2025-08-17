namespace DepoStokTakip
{
    partial class FormUrunEkle
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
            this.btnAnaMenu = new System.Windows.Forms.Button();
            this.btnCikisYap = new System.Windows.Forms.Button();
            this.txtUrunAdi = new System.Windows.Forms.TextBox();
            this.lblurunAdi = new System.Windows.Forms.Label();
            this.lblKategori = new System.Windows.Forms.Label();
            this.lblMarka = new System.Windows.Forms.Label();
            this.lblFiyat = new System.Windows.Forms.Label();
            this.lblStokMiktari = new System.Windows.Forms.Label();
            this.cmbKategori = new System.Windows.Forms.ComboBox();
            this.cmbMarka = new System.Windows.Forms.ComboBox();
            this.numFiyat = new System.Windows.Forms.NumericUpDown();
            this.numStokMiktari = new System.Windows.Forms.NumericUpDown();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.lblUrunEkle = new System.Windows.Forms.Label();
            this.grpUrunEkle = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.numFiyat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numStokMiktari)).BeginInit();
            this.grpUrunEkle.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAnaMenu
            // 
            this.btnAnaMenu.BackColor = System.Drawing.Color.Orange;
            this.btnAnaMenu.Location = new System.Drawing.Point(13, 438);
            this.btnAnaMenu.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnAnaMenu.Name = "btnAnaMenu";
            this.btnAnaMenu.Size = new System.Drawing.Size(225, 56);
            this.btnAnaMenu.TabIndex = 0;
            this.btnAnaMenu.Text = "Ana Menü";
            this.btnAnaMenu.UseVisualStyleBackColor = false;
            this.btnAnaMenu.Click += new System.EventHandler(this.btnAnaMenu_Click);
            // 
            // btnCikisYap
            // 
            this.btnCikisYap.BackColor = System.Drawing.Color.Red;
            this.btnCikisYap.Location = new System.Drawing.Point(246, 438);
            this.btnCikisYap.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnCikisYap.Name = "btnCikisYap";
            this.btnCikisYap.Size = new System.Drawing.Size(225, 56);
            this.btnCikisYap.TabIndex = 1;
            this.btnCikisYap.Text = "Çıkış Yap";
            this.btnCikisYap.UseVisualStyleBackColor = false;
            this.btnCikisYap.Click += new System.EventHandler(this.btnCikisYap_Click);
            // 
            // txtUrunAdi
            // 
            this.txtUrunAdi.Location = new System.Drawing.Point(34, 100);
            this.txtUrunAdi.Name = "txtUrunAdi";
            this.txtUrunAdi.Size = new System.Drawing.Size(267, 24);
            this.txtUrunAdi.TabIndex = 2;
            // 
            // lblurunAdi
            // 
            this.lblurunAdi.AutoSize = true;
            this.lblurunAdi.Location = new System.Drawing.Point(130, 65);
            this.lblurunAdi.Name = "lblurunAdi";
            this.lblurunAdi.Size = new System.Drawing.Size(72, 18);
            this.lblurunAdi.TabIndex = 3;
            this.lblurunAdi.Text = "Ürün Adı";
            // 
            // lblKategori
            // 
            this.lblKategori.AutoSize = true;
            this.lblKategori.Location = new System.Drawing.Point(496, 65);
            this.lblKategori.Name = "lblKategori";
            this.lblKategori.Size = new System.Drawing.Size(71, 18);
            this.lblKategori.TabIndex = 4;
            this.lblKategori.Text = "Kategori";
            // 
            // lblMarka
            // 
            this.lblMarka.AutoSize = true;
            this.lblMarka.Location = new System.Drawing.Point(130, 148);
            this.lblMarka.Name = "lblMarka";
            this.lblMarka.Size = new System.Drawing.Size(55, 18);
            this.lblMarka.TabIndex = 5;
            this.lblMarka.Text = "Marka";
            // 
            // lblFiyat
            // 
            this.lblFiyat.AutoSize = true;
            this.lblFiyat.Location = new System.Drawing.Point(509, 148);
            this.lblFiyat.Name = "lblFiyat";
            this.lblFiyat.Size = new System.Drawing.Size(44, 18);
            this.lblFiyat.TabIndex = 6;
            this.lblFiyat.Text = "Fiyat";
            // 
            // lblStokMiktari
            // 
            this.lblStokMiktari.AutoSize = true;
            this.lblStokMiktari.Location = new System.Drawing.Point(302, 221);
            this.lblStokMiktari.Name = "lblStokMiktari";
            this.lblStokMiktari.Size = new System.Drawing.Size(99, 18);
            this.lblStokMiktari.TabIndex = 7;
            this.lblStokMiktari.Text = "Stok Miktarı";
            // 
            // cmbKategori
            // 
            this.cmbKategori.FormattingEnabled = true;
            this.cmbKategori.Items.AddRange(new object[] {
            "Elektronik",
            "Giyim ",
            "Ev Aletleri"});
            this.cmbKategori.Location = new System.Drawing.Point(393, 100);
            this.cmbKategori.Name = "cmbKategori";
            this.cmbKategori.Size = new System.Drawing.Size(267, 26);
            this.cmbKategori.TabIndex = 8;
            // 
            // cmbMarka
            // 
            this.cmbMarka.FormattingEnabled = true;
            this.cmbMarka.Items.AddRange(new object[] {
            "Arçelik",
            "Samsung",
            "Apple"});
            this.cmbMarka.Location = new System.Drawing.Point(34, 169);
            this.cmbMarka.Name = "cmbMarka";
            this.cmbMarka.Size = new System.Drawing.Size(267, 26);
            this.cmbMarka.TabIndex = 9;
            // 
            // numFiyat
            // 
            this.numFiyat.Location = new System.Drawing.Point(393, 171);
            this.numFiyat.Name = "numFiyat";
            this.numFiyat.Size = new System.Drawing.Size(267, 24);
            this.numFiyat.TabIndex = 10;
            // 
            // numStokMiktari
            // 
            this.numStokMiktari.Location = new System.Drawing.Point(221, 242);
            this.numStokMiktari.Name = "numStokMiktari";
            this.numStokMiktari.Size = new System.Drawing.Size(267, 24);
            this.numStokMiktari.TabIndex = 11;
            // 
            // btnKaydet
            // 
            this.btnKaydet.BackColor = System.Drawing.Color.LimeGreen;
            this.btnKaydet.Location = new System.Drawing.Point(110, 301);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(241, 44);
            this.btnKaydet.TabIndex = 12;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = false;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnTemizle
            // 
            this.btnTemizle.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnTemizle.Location = new System.Drawing.Point(363, 301);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(241, 44);
            this.btnTemizle.TabIndex = 13;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.UseVisualStyleBackColor = false;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // lblUrunEkle
            // 
            this.lblUrunEkle.AutoSize = true;
            this.lblUrunEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUrunEkle.Location = new System.Drawing.Point(268, 20);
            this.lblUrunEkle.Name = "lblUrunEkle";
            this.lblUrunEkle.Size = new System.Drawing.Size(158, 29);
            this.lblUrunEkle.TabIndex = 14;
            this.lblUrunEkle.Text = "ÜRÜN EKLE";
            // 
            // grpUrunEkle
            // 
            this.grpUrunEkle.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.grpUrunEkle.Controls.Add(this.lblUrunEkle);
            this.grpUrunEkle.Controls.Add(this.btnTemizle);
            this.grpUrunEkle.Controls.Add(this.btnKaydet);
            this.grpUrunEkle.Controls.Add(this.numStokMiktari);
            this.grpUrunEkle.Controls.Add(this.numFiyat);
            this.grpUrunEkle.Controls.Add(this.cmbMarka);
            this.grpUrunEkle.Controls.Add(this.cmbKategori);
            this.grpUrunEkle.Controls.Add(this.lblStokMiktari);
            this.grpUrunEkle.Controls.Add(this.lblFiyat);
            this.grpUrunEkle.Controls.Add(this.lblMarka);
            this.grpUrunEkle.Controls.Add(this.lblKategori);
            this.grpUrunEkle.Controls.Add(this.lblurunAdi);
            this.grpUrunEkle.Controls.Add(this.txtUrunAdi);
            this.grpUrunEkle.Location = new System.Drawing.Point(136, 12);
            this.grpUrunEkle.Name = "grpUrunEkle";
            this.grpUrunEkle.Size = new System.Drawing.Size(703, 398);
            this.grpUrunEkle.TabIndex = 15;
            this.grpUrunEkle.TabStop = false;
            this.grpUrunEkle.Text = "groupBox1";
            // 
            // FormUrunEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1000, 506);
            this.Controls.Add(this.grpUrunEkle);
            this.Controls.Add(this.btnCikisYap);
            this.Controls.Add(this.btnAnaMenu);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FormUrunEkle";
            this.Text = "Ürün Ekleme Formu";
            ((System.ComponentModel.ISupportInitialize)(this.numFiyat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numStokMiktari)).EndInit();
            this.grpUrunEkle.ResumeLayout(false);
            this.grpUrunEkle.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAnaMenu;
        private System.Windows.Forms.Button btnCikisYap;
        private System.Windows.Forms.TextBox txtUrunAdi;
        private System.Windows.Forms.Label lblurunAdi;
        private System.Windows.Forms.Label lblKategori;
        private System.Windows.Forms.Label lblMarka;
        private System.Windows.Forms.Label lblFiyat;
        private System.Windows.Forms.Label lblStokMiktari;
        private System.Windows.Forms.ComboBox cmbKategori;
        private System.Windows.Forms.ComboBox cmbMarka;
        private System.Windows.Forms.NumericUpDown numFiyat;
        private System.Windows.Forms.NumericUpDown numStokMiktari;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.Label lblUrunEkle;
        private System.Windows.Forms.GroupBox grpUrunEkle;
    }
}