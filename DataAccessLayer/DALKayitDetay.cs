using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;
using System.Data;
using System.Data.SqlClient;

namespace DataAccessLayer
{
    public class DALKayitDetay
    {
        public static bool KayitaGoreKayitDetayVarMi(EntityKayitDefteri kayit)
        {

            SqlCommand sorgu = new SqlCommand("SELECT * FROM KayitDefteriValues WHERE KayitDefteriId = @A1", Baglanti.bgl);
            if (sorgu.Connection.State != ConnectionState.Open)
            {
                sorgu.Connection.Open();
            }
            sorgu.Parameters.AddWithValue("@A1", kayit.Id);
            SqlDataReader oku = sorgu.ExecuteReader();
            int KayitSayisi = 0;
            while (oku.Read())
            {
                KayitSayisi++;
            }
            oku.Close();
            if (KayitSayisi > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool KayitDetayEkle(EntityKayitDetay kayitDetay)
        {

            SqlCommand KayitEkle = new SqlCommand("INSERT INTO KayitDefteriValues (ValueType, ValueName, KayitDefteriId) VALUES (@A1, @A2, @A3)", Baglanti.bgl);
            if (KayitEkle.Connection.State != ConnectionState.Open)
            {
                KayitEkle.Connection.Open();
            }
            KayitEkle.Parameters.AddWithValue("@A1", kayitDetay.ValueType);
            KayitEkle.Parameters.AddWithValue("@A2", kayitDetay.ValueName);
            KayitEkle.Parameters.AddWithValue("@A3", kayitDetay.KayitDefteriId);
            return KayitEkle.ExecuteNonQuery() > 0;

        }
        public static List<EntityKayitDetay> KayitlariGetir(EntityKayitDefteri kayit)
        {

            List<EntityKayitDetay> KayitDetaylar = new List<EntityKayitDetay>();

            SqlCommand sorgu = new SqlCommand("SELECT * FROM KayitDefteriValues WHERE KayitDefteriId = @A1", Baglanti.bgl);
            if (sorgu.Connection.State != ConnectionState.Open)
            {
                sorgu.Connection.Open();
            }
            sorgu.Parameters.AddWithValue("@A1", kayit.Id);
            SqlDataReader oku = sorgu.ExecuteReader();
            while (oku.Read())
            {
                EntityKayitDetay kayitDetay = new EntityKayitDetay();
                kayitDetay.Id = int.Parse(oku["ID"].ToString());
                kayitDetay.ValueType = oku["VALUETYPE"].ToString();
                kayitDetay.ValueName = oku["VALUENAME"].ToString();
                kayitDetay.KayitDefteriId = Convert.ToInt32(oku["KayitDefteriId"].ToString());
                KayitDetaylar.Add(kayitDetay);
            }
            oku.Close();
            if (KayitDetaylar.Count > 0)
            {
                return KayitDetaylar;
            }
            else
            {
                return null;
            }

        }

        public static bool KayitDetayGuncelle(EntityKayitDetay kayitDetay)
        {

            SqlCommand KayitGuncelle = new SqlCommand("UPDATE KayitDefteriValues SET ValueType = @D1, ValueName = @D2 WHERE Id=@D3", Baglanti.bgl);
            if (KayitGuncelle.Connection.State != ConnectionState.Open)
            {
                KayitGuncelle.Connection.Open();
            }
            KayitGuncelle.Parameters.AddWithValue("@D3", kayitDetay.Id);
            KayitGuncelle.Parameters.AddWithValue("@D1", kayitDetay.ValueType);
            KayitGuncelle.Parameters.AddWithValue("@D2", kayitDetay.ValueName);
            return KayitGuncelle.ExecuteNonQuery() > 0;

        }
        public static bool KayitDetaySil(EntityKayitDetay kayitDetay)
        {
            SqlCommand KayitSil = new SqlCommand("DELETE FROM KayitDefteriValues WHERE Id=@A1", Baglanti.bgl);
            if (KayitSil.Connection.State != ConnectionState.Open)
            {
                KayitSil.Connection.Open();
            }
            KayitSil.Parameters.AddWithValue("@A1", kayitDetay.Id);
            return KayitSil.ExecuteNonQuery() > 0;
        }
    }
}
