using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
using EntityLayer;

namespace LogicLayer
{
    public class LogicKayitDefteri
    {

        public static List<EntityKayitDefteri> KayitDefteriKayitlariGetir(EntityKullanici kullanici)
        {
            if(!(kullanici.Id.ToString() == ""))
            { 
              
                return DALKayitDefteri.KayitlariGetir(kullanici);

            }
            else
            {
                return null;
            }


        }
        
        public static bool KayitDefteriGuncelle(EntityKayitDefteri kayit) { 
        
            if(kayit.Isim != "" && kayit.Numara != "")
            {
                return DALKayitDefteri.KayitGuncelle(kayit);
            }
            else
            {
                return false;
            }

        }

        public static bool KayitEkle(EntityKayitDefteri kayit)
        {
            if (kayit.Isim != "" && kayit.Numara != "")
            {
                return DALKayitDefteri.KayitEkle(kayit);
            }
            else
            {
                return false;
            }
        }

        public static bool KayitSil(EntityKayitDefteri kayit)
        {
            if (kayit.Id.ToString() != "")
            {
                if (DALKayitDetay.KayitaGoreKayitDetayVarMi(kayit))
                {
                    var kayitDetaylari = DALKayitDetay.KayitlariGetir(kayit);
                    for(int i = 0; i < kayitDetaylari.Count; i++)
                    {
                        if (!DALKayitDetay.KayitDetaySil(kayitDetaylari[i]))
                        {
                            return false;
                        }
                    }

                    return DALKayitDefteri.KayitSil(kayit);
                }
                else
                {
                    return DALKayitDefteri.KayitSil(kayit);
                }
            }
            else
            {
                return false;
            }
        }

    }
}
