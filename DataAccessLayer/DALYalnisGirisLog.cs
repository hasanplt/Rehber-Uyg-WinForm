using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using EntityLayer;

namespace DataAccessLayer
{
    public class DALYalnisGirisLog
    {

        public static bool YalnisGirisEkle(EntityKullanici kullanici)
        {

            EntityYalnisGirisLog log = new EntityYalnisGirisLog();
            log.Zaman = DateTime.Now;
            log.KId = kullanici.Id;

            SqlCommand Komut = new SqlCommand("INSERT INTO YalnisGirisLog (Zaman, KId) VALUES (@A1, @A2)", Baglanti.bgl);
            if (Komut.Connection.State != ConnectionState.Open)
            {
                Komut.Connection.Open();
            }
            Komut.Parameters.AddWithValue("@A1", log.Zaman);
            Komut.Parameters.AddWithValue("@A2", log.KId);

            return Komut.ExecuteNonQuery() > 0;
        }

        public static List<EntityYalnisGirisLog> YalnisGirisVarMi(EntityKullanici kullanici)
        {
            List<EntityYalnisGirisLog> loglar = new List<EntityYalnisGirisLog>();

            SqlCommand varMi = new SqlCommand("SELECT * FROM YalnisGirisLog WHERE KId = @A1", Baglanti.bgl);
            if (varMi.Connection.State != ConnectionState.Open)
            {
                varMi.Connection.Open();
            }
            varMi.Parameters.AddWithValue("@A1", kullanici.Id);

            SqlDataReader DR = varMi.ExecuteReader();
            while (DR.Read())
            {
                EntityYalnisGirisLog log = new EntityYalnisGirisLog();
                log.KId = Convert.ToInt32(DR["KID"].ToString());
                log.Zaman = Convert.ToDateTime(DR["ZAMAN"]);
                log.Id = int.Parse(DR["ID"].ToString());
                loglar.Add(log);
            }
            DR.Close();

            if (loglar.Count > 0)
            {
                return loglar;
            }
            else
            {
                return null;
            }
        }

        public static bool YalnisGirisSil(EntityYalnisGirisLog YalnisGiris)
        {
            SqlCommand komut = new SqlCommand("DELETE FROM YalnisGirisLog WHERE Id=@P1", Baglanti.bgl);
            if (komut.Connection.State != ConnectionState.Open)
            {
                komut.Connection.Open();
            }
            komut.Parameters.AddWithValue("@P1", YalnisGiris.Id);
            return komut.ExecuteNonQuery() > 0;
        }
    }
}
