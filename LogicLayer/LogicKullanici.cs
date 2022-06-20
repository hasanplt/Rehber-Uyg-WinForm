using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
using EntityLayer;

namespace LogicLayer
{
    public class LogicKullanici
    {
        public static bool GirisKontrol(EntityKullanici kullanici)
        {
            if (kullanici.KullaniciAd == "" && kullanici.Sifre == "")
            {
                return false;
            }

            kullanici = DALKullanici.KAdGoreKullaniciGetir(kullanici).FirstOrDefault();

            bool kullaniciVarMi = DALKullanici.KullaniciVarMi(kullanici);
            if (kullaniciVarMi)
            {
                bool SifreDogruMu = DALKullanici.SifreDogruMu(kullanici);
                if (SifreDogruMu)
                {
                    return true;
                }
                else
                {
                    DALYalnisGirisLog.YalnisGirisEkle(kullanici);
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
        
        public static EntityKullanici kullaniciVerileriTamamla(EntityKullanici kullanici)
        {
            if(kullanici.KullaniciAd != "")
            {
                return DALKullanici.KAdGoreKullaniciGetir(kullanici).FirstOrDefault();
            }
            else
            {
                return kullanici;
            }
        }
    }
}
