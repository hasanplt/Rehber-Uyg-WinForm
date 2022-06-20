using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class EntityKullanici
    {
        private int id;
        private string ad;
        private string soyad;
        private string kullaniciAd;
        private string sifre;
        private string fotografAdres;

        public int Id { get => id; set => id = value; }
        public string Ad { get => ad; set => ad = value; }
        public string Soyad { get => soyad; set => soyad = value; }
        public string KullaniciAd { get => kullaniciAd; set => kullaniciAd = value; }
        public string Sifre { get => sifre; set => sifre = value; }
        public string FotografAdres { get => fotografAdres; set => fotografAdres = value; }
    }
}
