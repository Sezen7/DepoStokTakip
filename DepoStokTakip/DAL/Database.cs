
using DepoStokTakip.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

public class Database
{
    private string connectionString = "Server=localhost\\SQLEXPRESS;Database=DepoStokDB;Trusted_Connection=True;";

    public void BaglantiTest()
    {
        using (SqlConnection conn = new SqlConnection(connectionString))
        {
            conn.Open();
            Console.WriteLine("Bağlantı başarılı!");
        }
    }

    public void UrunEkle(Urun u)
    {
        using (SqlConnection conn = new SqlConnection(connectionString))
        {
            string query = "INSERT INTO Urunler (QRKod, UrunAdi, KategoriID, MarkaID, Birim, StokMiktari, MinStok, Aciklama) " +
                           "VALUES (@QRKod, @UrunAdi, @KategoriID, @MarkaID, @Birim, @StokMiktari, @MinStok, @Aciklama)";

            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@QRKod", u.QRKod ?? "");
            cmd.Parameters.AddWithValue("@UrunAdi", u.UrunAdi);
            cmd.Parameters.AddWithValue("@KategoriID", u.KategoriID);
            cmd.Parameters.AddWithValue("@MarkaID", u.MarkaID);
            cmd.Parameters.AddWithValue("@Birim", u.Birim ?? "");
            cmd.Parameters.AddWithValue("@StokMiktari", u.StokMiktari);
            cmd.Parameters.AddWithValue("@MinStok", u.MinStok);
            cmd.Parameters.AddWithValue("@Aciklama", u.Aciklama ?? "");

            conn.Open();
            cmd.ExecuteNonQuery();
        }
    }

    public List<Urun> UrunListele()
    {
        List<Urun> urunler = new List<Urun>();
        using (SqlConnection conn = new SqlConnection(connectionString))
        {
            string query = "SELECT * FROM Urunler";
            SqlCommand cmd = new SqlCommand(query, conn);
            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                urunler.Add(new Urun
                {
                    ID = (int)reader["ID"],
                    QRKod = reader["QRKod"].ToString(),
                    UrunAdi = reader["UrunAdi"].ToString(),
                    KategoriID = (int)reader["KategoriID"],
                    MarkaID = (int)reader["MarkaID"],
                    Birim = reader["Birim"].ToString(),
                    StokMiktari = (int)reader["StokMiktari"],
                    MinStok = (int)reader["MinStok"],
                    Aciklama = reader["Aciklama"].ToString()
                });
            }
        }
        return urunler;
    }
}
