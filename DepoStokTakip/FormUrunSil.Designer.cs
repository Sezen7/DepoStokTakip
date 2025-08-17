namespace DepoStokTakip
{
    partial class FormUrunSil
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
            this.btnCikisyap = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAnaMenu
            // 
            this.btnAnaMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAnaMenu.Location = new System.Drawing.Point(435, 400);
            this.btnAnaMenu.Name = "btnAnaMenu";
            this.btnAnaMenu.Size = new System.Drawing.Size(180, 50);
            this.btnAnaMenu.TabIndex = 0;
            this.btnAnaMenu.Text = "Ana Menü";
            this.btnAnaMenu.UseVisualStyleBackColor = true;
            this.btnAnaMenu.Click += new System.EventHandler(this.btnAnaMenu_Click);
            // 
            // btnCikisyap
            // 
            this.btnCikisyap.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCikisyap.Location = new System.Drawing.Point(621, 400);
            this.btnCikisyap.Name = "btnCikisyap";
            this.btnCikisyap.Size = new System.Drawing.Size(180, 50);
            this.btnCikisyap.TabIndex = 1;
            this.btnCikisyap.Text = "Çıkış Yap";
            this.btnCikisyap.UseVisualStyleBackColor = true;
            this.btnCikisyap.Click += new System.EventHandler(this.btnCikisyap_Click);
            // 
            // FormUrunSil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCikisyap);
            this.Controls.Add(this.btnAnaMenu);
            this.Name = "FormUrunSil";
            this.Text = "FormUrunSil";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAnaMenu;
        private System.Windows.Forms.Button btnCikisyap;
    }
}