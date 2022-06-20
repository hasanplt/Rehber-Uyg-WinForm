using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
using EntityLayer;

namespace LogicLayer
{
    public class LogicKayitDetay
    {
        public static List<EntityKayitDetay> KayitDetayGetir(EntityKayitDefteri kayit)
        {

            return DALKayitDetay.KayitlariGetir(kayit);

        }
        public static bool KayitDetayEkle(EntityKayitDetay kayitDetay)
        {
            if (kayitDetay.ValueType != "" && kayitDetay.ValueName != "")
            {
                return DALKayitDetay.KayitDetayEkle(kayitDetay);
            }
            else
            {
                return false;
            }
        }
        public static bool KayitDetayGuncelle(EntityKayitDetay kayitDetay)
        {
            if (kayitDetay.ValueType != "" && kayitDetay.ValueName != "")
            {
                return DALKayitDetay.KayitDetayGuncelle(kayitDetay);
            }
            else
            {
                return false;
            }
        }

        public static bool KayitDetaySil(EntityKayitDetay kayitDetay)
        {
            if (kayitDetay.Id.ToString() != "")
            {
                return DALKayitDetay.KayitDetaySil(kayitDetay);
            }
            else
            {
                return false;
            }
        }
    }
}
