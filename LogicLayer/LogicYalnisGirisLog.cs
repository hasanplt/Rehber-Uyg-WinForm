using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
using EntityLayer;

namespace LogicLayer
{
    public class LogicYalnisGirisLog
    {
        public static List<EntityYalnisGirisLog> YalnisGirisKontrol(EntityKullanici kullanici)
        {

            var data = DALYalnisGirisLog.YalnisGirisVarMi(kullanici);
            if (data != null)
            {
                return data;
            }
            else
            {
                return null;
            }
        }

        public static bool YalnisGirisSilKontrol(List<EntityYalnisGirisLog> yalnisGirisLoglar)
        {

            for(int i = 0; i < yalnisGirisLoglar.Count; i++)
            {
                DALYalnisGirisLog.YalnisGirisSil(yalnisGirisLoglar[i]);
            }

            return true;

        }
    }
}
