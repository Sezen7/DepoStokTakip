using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DepoStokTakip
{
    public partial class FormUrunEkle : Form
    {
        public FormUrunEkle()
        {
            InitializeComponent();
        }
        

        private void DoldurComboBox(ComboBox cmb, string tabloAdi, string idKolon, string adKolon)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection("Server=localhost\\SQLEXPRESS;Database=DepoStokDB;Trusted_Connection=True;"))
                {
                    conn.Open();
                    string query = $"SELECT {idKolon}, {adKolon} FROM {tabloAdi}";
                    SqlDataAdapter da = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    cmb.DataSource = dt;
                    cmb.ValueMember = idKolon;     // ID
                    cmb.DisplayMember = adKolon;   // Görünen isim
                    cmb.SelectedIndex = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }
        private void FormUrunEkle_Load(object sender, EventArgs e)
        {
            // Kategori ve Marka ComboBox’larını doldur
            DoldurComboBox(cmbKategori, "Kategoriler", "ID", "KategoriAdi");
            DoldurComboBox(cmbMarka, "Markalar", "ID", "MarkaAdi");

            // İlk öğeyi seçili yap (null dönme riskini önler)
            if (cmbKategori.Items.Count > 0)
                cmbKategori.SelectedIndex = 0;

            if (cmbMarka.Items.Count > 0)
                cmbMarka.SelectedIndex = 0;

            // Test: Seçili ID’leri debug için yazdır
            if (cmbKategori.SelectedValue != null && cmbMarka.SelectedValue != null)
            {
                int seciliKategoriID = Convert.ToInt32(cmbKategori.SelectedValue);
                int seciliMarkaID = Convert.ToInt32(cmbMarka.SelectedValue);
                Console.WriteLine($"Seçili KategoriID: {seciliKategoriID}, Seçili MarkaID: {seciliMarkaID}");
            }
        }





        private void btnAnaMenu_Click(object sender, EventArgs e)
        {
            int rolID = 1; // Örnek: Admin rolü
            FormNavigator.ReturnToMainMenu(this, rolID);
        }

        private void btnCikisYap_Click(object sender, EventArgs e)
        {
            FormNavigator.Logout(this);
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            // 1. Alanların boş olup olmadığını kontrol et.
            if (string.IsNullOrEmpty(txtUrunAdi.Text.Trim()) || cmbKategori.SelectedIndex == -1 || cmbMarka.SelectedIndex == -1)
            {
                MessageBox.Show("Lütfen tüm alanları doldurun!");
                return;
            }

            // 2. Formdaki verileri güvenli bir şekilde değişkenlere aktar.
            string urunAdi = txtUrunAdi.Text.Trim();
            decimal fiyat = numFiyat.Value;
            int stok = (int)numStokMiktari.Value;

            // **ÖNEMLİ DÜZELTME:** ComboBox'tan gelen ID değerlerini güvenli bir şekilde al.
            int kategoriID = -1;
            if (cmbKategori.SelectedValue != null && cmbKategori.SelectedValue != DBNull.Value)
            {
                kategoriID = Convert.ToInt32(cmbKategori.SelectedValue);
            }

            int markaID = -1;
            if (cmbMarka.SelectedValue != null && cmbMarka.SelectedValue != DBNull.Value)
            {
                markaID = Convert.ToInt32(cmbMarka.SelectedValue);
            }

            // Eğer ID'lerden herhangi biri geçersizse (örn. -1), işlem yapma.
            if (kategoriID == -1 || markaID == -1)
            {
                MessageBox.Show("Lütfen geçerli bir kategori ve marka seçin!");
                return;
            }

            // Bu satır, hata ayıklama (debug) amaçlıdır. Sorun çözülünce kaldırabilirsiniz.
            MessageBox.Show($"Gönderilen KategoriID: {kategoriID}");

            // 3. Veritabanı işlemlerini bir try-catch bloğu içine alarak hataları yakala.
            try
            {
                using (SqlConnection conn = new SqlConnection("Server=localhost\\SQLEXPRESS;Database=DepoStokDB;Trusted_Connection=True;"))
                {
                    conn.Open();

                    string qrKod = Guid.NewGuid().ToString();

                    // Urunler tablosuna ekle
                    string queryUrun = @"INSERT INTO Urunler (UrunAdi, KategoriID, MarkaID, Fiyat, StokMiktari, QRKod) 
                                 VALUES (@adi, @kategoriID, @markaID, @fiyat, @stok, @qrKod)";
                    using (SqlCommand cmd = new SqlCommand(queryUrun, conn))
                    {
                        cmd.Parameters.AddWithValue("@adi", urunAdi);
                        cmd.Parameters.AddWithValue("@kategoriID", kategoriID);
                        cmd.Parameters.AddWithValue("@markaID", markaID);
                        cmd.Parameters.AddWithValue("@fiyat", fiyat);
                        cmd.Parameters.AddWithValue("@stok", stok);
                        cmd.Parameters.AddWithValue("@qrKod", qrKod);
                        cmd.ExecuteNonQuery();
                    }

                    // StokHareketleri tablosuna başlangıç kaydı
                    string queryStok = @"INSERT INTO StokHareketleri (Barkod, Islemtipi, Miktar, Tarih) 
                                 VALUES (@barkod, 'Giriş', @miktar, GETDATE())";
                    using (SqlCommand cmd2 = new SqlCommand(queryStok, conn))
                    {
                        cmd2.Parameters.AddWithValue("@barkod", qrKod);
                        cmd2.Parameters.AddWithValue("@miktar", stok);
                        cmd2.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Ürün başarıyla eklendi!");
                TemizleForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            TemizleForm();
        }
        private void TemizleForm()
        {
            txtUrunAdi.Clear();
            cmbKategori.SelectedIndex = 0;
            cmbMarka.SelectedIndex = 0;
            numFiyat.Value = 0;
            numStokMiktari.Value = 0;
        }

    }
}
