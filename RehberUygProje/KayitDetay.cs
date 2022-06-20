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
using LogicLayer;
using DataAccessLayer;

namespace RehberUygProje
{
    public partial class KayitDetay : Form
    {
        public KayitDetay()
        {
            InitializeComponent();
        }

        public static EntityKayitDefteri kayit;
        public static EntityKullanici kullanici;

        private void KayitlariGetir()
        {
            var data = LogicKayitDetay.KayitDetayGetir(kayit);
            dataGridView1.DataSource = data;
            if(data != null)
            {
                dataGridView1.Columns["Id"].Visible = false;
                dataGridView1.Columns["KayitDefteriId"].Visible = false;
            }
        }

        private void KayitDetay_Load(object sender, EventArgs e)
        {
            TxtIsim.Text = kayit.Isim;
            TxtNumara.Text = kayit.Numara;
            KayitlariGetir();
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            kayit.Isim = TxtIsim.Text;
            kayit.Numara = TxtNumara.Text;
            if (LogicKayitDefteri.KayitDefteriGuncelle(kayit))
            {
                MessageBox.Show("Kayıt Başarılı!");
            }
            else
            {
                MessageBox.Show("Kayıt Başarısız... Tekrar Deneyiniz!");
            }
        }

        private void BtnKayitSil_Click(object sender, EventArgs e)
        {
            if (LogicKayitDefteri.KayitSil(kayit))
            {
                this.Hide();
                MessageBox.Show("Kayıt Başarıyla Silindi!..");
            }
            else
            {
                MessageBox.Show("Kayıt Silinirken Bir Sorunla Karşılaşıldı...");
            }
        }

        private void BtnDetay_Click(object sender, EventArgs e)
        {
            EntityKayitDetay kayitDetay = new EntityKayitDetay();
            kayitDetay.ValueType = TxtDetayTip.Text;
            kayitDetay.ValueName = TxtDetayDeger.Text;
            kayitDetay.KayitDefteriId = kayit.Id;
            if (LogicKayitDetay.KayitDetayEkle(kayitDetay))
            {
                MessageBox.Show("Kayıt Detayı Eklendi!");
                TxtDetayTip.Text = "";
                TxtDetayDeger.Text = "";
            }
            else
            {
                MessageBox.Show("Kayıt Detayı Eklenemedi!..");
            }
        }

        private void BtnDetayGetir_Click(object sender, EventArgs e)
        {
            KayitlariGetir();
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            var detaylar = LogicKayitDetay.KayitDetayGetir(kayit);
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            var detay = detaylar[secilen];
            KayitDetayininDetayi detaySayfa = new KayitDetayininDetayi();
            detaySayfa.detay = detay;
            detaySayfa.Show();
        }
    }
}
