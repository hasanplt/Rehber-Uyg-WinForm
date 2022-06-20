using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EntityLayer;
using DataAccessLayer;
using LogicLayer;

namespace RehberUygProje
{
    public partial class GirisPanel : Form
    {
        public GirisPanel()
        {
            InitializeComponent();
        }
        private void BtnGiris_Click(object sender, EventArgs e)
        {
            EntityKullanici kullanici = new EntityKullanici();
            kullanici.KullaniciAd = TxtKullaniciAd.Text;
            kullanici.Sifre = TxtSifre.Text;
            bool kontrol = LogicKullanici.GirisKontrol(kullanici);

            if (kontrol)
            {
                AnaSayfa anasayfa = new AnaSayfa();
                anasayfa.kullanici = kullanici;
                anasayfa.Show();

                var veri = LogicYalnisGirisLog.YalnisGirisKontrol(kullanici);

                if (veri != null)
                {
                    BasarisizGirisler basarisizGirisler = new BasarisizGirisler();
                    basarisizGirisler.logicYalnisGirisLoglar = veri;
                    basarisizGirisler.Show();
                }

                this.Hide();

               
            }
            else
            {
                MessageBox.Show("Başarısız Giriş! Tekrar Deneyiniz...");
            }
        }

        private void GirisPanel_Load(object sender, EventArgs e)
        {

        }
    }
}
