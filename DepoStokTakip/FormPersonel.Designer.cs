namespace DepoStokTakip
{
    partial class FormPersonel
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
            this.btnUrunListele = new System.Windows.Forms.Button();
            this.btnUrunEkle = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.lblAnaMenu = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnUrunListele
            // 
            this.btnUrunListele.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnUrunListele.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUrunListele.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnUrunListele.Location = new System.Drawing.Point(77, 220);
            this.btnUrunListele.Name = "btnUrunListele";
            this.btnUrunListele.Size = new System.Drawing.Size(395, 55);
            this.btnUrunListele.TabIndex = 0;
            this.btnUrunListele.Text = "Ürün Listele";
            this.btnUrunListele.UseVisualStyleBackColor = false;
            this.btnUrunListele.Click += new System.EventHandler(this.btnUrunListele_Click);
            // 
            // btnUrunEkle
            // 
            this.btnUrunEkle.BackColor = System.Drawing.Color.LimeGreen;
            this.btnUrunEkle.Cursor = System.Windows.Forms.Cursors.Cross;
            this.btnUrunEkle.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUrunEkle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnUrunEkle.Location = new System.Drawing.Point(77, 298);
            this.btnUrunEkle.Name = "btnUrunEkle";
            this.btnUrunEkle.Size = new System.Drawing.Size(395, 55);
            this.btnUrunEkle.TabIndex = 1;
            this.btnUrunEkle.Text = "Ürün Ekle";
            this.btnUrunEkle.UseVisualStyleBackColor = false;
            this.btnUrunEkle.Click += new System.EventHandler(this.btnUrunEkle_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Red;
            this.button4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button4.Location = new System.Drawing.Point(169, 385);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(220, 59);
            this.button4.TabIndex = 3;
            this.button4.Text = "Çıkış Yap";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // lblAnaMenu
            // 
            this.lblAnaMenu.AutoSize = true;
            this.lblAnaMenu.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAnaMenu.Location = new System.Drawing.Point(191, 121);
            this.lblAnaMenu.Name = "lblAnaMenu";
            this.lblAnaMenu.Size = new System.Drawing.Size(183, 41);
            this.lblAnaMenu.TabIndex = 4;
            this.lblAnaMenu.Text = "ANA MENÜ";
            // 
            // FormPersonel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(586, 772);
            this.Controls.Add(this.lblAnaMenu);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btnUrunEkle);
            this.Controls.Add(this.btnUrunListele);
            this.Name = "FormPersonel";
            this.Text = "FormPersonel";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUrunListele;
        private System.Windows.Forms.Button btnUrunEkle;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label lblAnaMenu;
    }
}