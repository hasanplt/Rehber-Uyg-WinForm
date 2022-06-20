using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using EntityLayer;
using System.Security.Cryptography;

namespace DataAccessLayer
{
    public class DALKullanici
    {

        // Şifreleme
        public static string EncryptWithMD5(string ClearString)
        {
            System.Text.UnicodeEncoding objUE = new System.Text.UnicodeEncoding();

            byte[] bytClearString = objUE.GetBytes(ClearString);

            MD5CryptoServiceProvider objProv = new MD5CryptoServiceProvider();

            byte[] hash = objProv.ComputeHash(bytClearString);
            return Convert.ToBase64String(hash);
        }

        public static bool KullaniciVarMi(EntityKullanici kullanici)
        {
            List<EntityKullanici> kullanicilar = new List<EntityKullanici>();
            SqlCommand varMi = new SqlCommand("SELECT * FROM Kullanici WHERE KullaniciAd = @A1", Baglanti.bgl);
            if(varMi.Connection.State != ConnectionState.Open)
            {
                varMi.Connection.Open();
            }
            varMi.Parameters.AddWithValue("@A1", kullanici.KullaniciAd);
            SqlDataReader DR = varMi.ExecuteReader();
            while (DR.Read())
            {
                EntityKullanici user = new EntityKullanici();
                user.KullaniciAd = DR["KullaniciAd"].ToString();
                kullanicilar.Add(user);
            }
            DR.Close();
            if (kullanicilar.Count == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        // düzelt
        public static bool SifreDogruMu(EntityKullanici kullanici)
        {
            List<EntityKullanici> kullanicilar = new List<EntityKullanici>();
            SqlCommand Sorgu = new SqlCommand("SELECT * FROM Kullanici WHERE KullaniciAd = @B1 and Sifre = @B2", Baglanti.bgl);
            if (Sorgu.Connection.State != ConnectionState.Open)
            {
                Sorgu.Connection.Open();
            }
            Sorgu.Parameters.AddWithValue("@B1", kullanici.KullaniciAd);
            Sorgu.Parameters.AddWithValue("@B2", EncryptWithMD5(kullanici.Sifre));
            SqlDataReader SorguRead = Sorgu.ExecuteReader();
            while (SorguRead.Read())
            {
                EntityKullanici user = new EntityKullanici();
                user.KullaniciAd = SorguRead["KullaniciAd"].ToString();
                kullanicilar.Add(user);
            }
            SorguRead.Close();
            if (kullanicilar.Count == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static List<EntityKullanici> KAdGoreKullaniciGetir(EntityKullanici kullanici)
        {
            SqlCommand kullaniciDetaylari = new SqlCommand("SELECT * from Kullanici WHERE KullaniciAd = @B1", Baglanti.bgl);

            if (kullaniciDetaylari.Connection.State != ConnectionState.Open)
            {
                kullaniciDetaylari.Connection.Open();
            }

            kullaniciDetaylari.Parameters.AddWithValue("@B1", kullanici.KullaniciAd);

            List<EntityKullanici> kullanicilar = new List<EntityKullanici>();

            SqlDataReader dr = kullaniciDetaylari.ExecuteReader();

            while (dr.Read())
            {
                kullanici.Id = Convert.ToInt32(dr["ID"].ToString());
                kullanici.Ad = dr["AD"].ToString();
                kullanici.Soyad = dr["SOYAD"].ToString();
                kullanici.FotografAdres = dr["FOTOGRAFADRES"].ToString();
                kullanicilar.Add(kullanici);
            }

            dr.Close();

            if (kullanicilar.Count == 0)
            {
                kullanicilar.Add(kullanici);
            }

            return kullanicilar;
        }

    }
}
