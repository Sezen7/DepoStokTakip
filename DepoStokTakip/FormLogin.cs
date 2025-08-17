using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace DepoStokTakip
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        // Giriş butonu
        private void btnGiris_Click(object sender, EventArgs e)
        {
            string kullaniciAdi = txtKullaniciAdi.Text;
            string sifre = txtSifre.Text;

            if (string.IsNullOrEmpty(kullaniciAdi) || string.IsNullOrEmpty(sifre))
            {
                lblMesaj.Text = "Lütfen kullanıcı adı ve şifreyi girin!";
                lblMesaj.ForeColor = Color.Red;
                return;
            }

            string connectionString = @"Server=localhost\SQLEXPRESS;Database=DepoStokDB;Trusted_Connection=True;";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT RolID FROM Kullanicilar WHERE KullaniciAdi=@kullanici AND Sifre=@sifre";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@kullanici", kullaniciAdi);
                    cmd.Parameters.AddWithValue("@sifre", sifre);

                    object result = cmd.ExecuteScalar();

                    if (result != null)
                    {
                        int rolID = Convert.ToInt32(result);

                        // Yetkiye göre form aç
                        if (rolID == 1) // Admin
                        {
                            FormAdmin formAdmin = new FormAdmin();
                            formAdmin.Show();
                        }
                        else // Personel
                        {
                            FormPersonel formPersonel = new FormPersonel();
                            formPersonel.Show();
                        }

                        this.Hide();
                    }
                    else
                    {
                        lblMesaj.Text = "Kullanıcı adı veya şifre hatalı!";
                        lblMesaj.ForeColor = Color.Red;
                    }
                }
                catch (Exception ex)
                {
                    lblMesaj.Text = "Hata: " + ex.Message;
                    lblMesaj.ForeColor = Color.Red;
                }
            }
        }


        // Şifreyi göster checkbox’ı
        private void chkSifreGoster_CheckedChanged(object sender, EventArgs e)
        {
            if (chkSifreGoster.Checked)
            {
                txtSifre.PasswordChar = '\0'; // Şifreyi göster
            }
            else
            {
                txtSifre.PasswordChar = '*'; // Şifreyi gizle
            }

        }

        
    }
    }
