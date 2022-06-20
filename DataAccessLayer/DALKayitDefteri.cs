using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using EntityLayer;

namespace DataAccessLayer
{
    public class DALKayitDefteri
    {

        public static List<EntityKayitDefteri> KayitlariGetir(EntityKullanici kullanici)
        {
            List<EntityKayitDefteri> Kayitlar = new List<EntityKayitDefteri>();

            SqlCommand sorgu = new SqlCommand("SELECT * FROM KayitDefteri WHERE SahipId = @A1", Baglanti.bgl);
            if (sorgu.Connection.State != ConnectionState.Open)
            {
                sorgu.Connection.Open();
            }
            sorgu.Parameters.AddWithValue("@A1", kullanici.Id);
            SqlDataReader oku = sorgu.ExecuteReader();
            while (oku.Read())
            {
                EntityKayitDefteri kayit = new EntityKayitDefteri();
                kayit.Id = int.Parse(oku["ID"].ToString());
                kayit.Isim = oku["Isim"].ToString();
                kayit.Numara = oku["Numara"].ToString();
                kayit.SahipId = int.Parse(oku["SahipId"].ToString());
                Kayitlar.Add(kayit);
            }
            oku.Close();
            if (Kayitlar.Count > 0)
            {
                return Kayitlar;
            }
            else
            {
                return null;
            }

        }

        public static bool KayitGuncelle(EntityKayitDefteri kayit)
        {

            SqlCommand KayitGuncelle = new SqlCommand("UPDATE KayitDefteri SET Isim = @B1, Numara = @B2 WHERE Id=@A1", Baglanti.bgl);
            if (KayitGuncelle.Connection.State != ConnectionState.Open)
            {
                KayitGuncelle.Connection.Open();
            }
            KayitGuncelle.Parameters.AddWithValue("@A1", kayit.Id);
            KayitGuncelle.Parameters.AddWithValue("@B1", kayit.Isim);
            KayitGuncelle.Parameters.AddWithValue("@B2", kayit.Numara);
            return KayitGuncelle.ExecuteNonQuery() > 0;

        }

        public static bool KayitEkle(EntityKayitDefteri kayit)
        {

            SqlCommand KayitEkle = new SqlCommand("INSERT INTO KayitDefteri (Isim,Numara, SahipId) VALUES (@C1, @C2, @C3)", Baglanti.bgl);
            if (KayitEkle.Connection.State != ConnectionState.Open)
            {
                KayitEkle.Connection.Open();
            }
            KayitEkle.Parameters.AddWithValue("@C1", kayit.Isim);
            KayitEkle.Parameters.AddWithValue("@C2", kayit.Numara);
            KayitEkle.Parameters.AddWithValue("@C3", kayit.SahipId);
            return KayitEkle.ExecuteNonQuery() > 0;

        }

        public static bool KayitSil(EntityKayitDefteri kayit)
        {
            SqlCommand KayitSil = new SqlCommand("DELETE FROM KayitDefteri WHERE Id=@A1", Baglanti.bgl);
            if (KayitSil.Connection.State != ConnectionState.Open)
            {
                KayitSil.Connection.Open();
            }
            KayitSil.Parameters.AddWithValue("@A1", kayit.Id);
            return KayitSil.ExecuteNonQuery() > 0;
        }

    }
}
