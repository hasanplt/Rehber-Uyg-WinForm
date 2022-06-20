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
using System.IO;

namespace RehberUygProje
{
    public partial class AnaSayfa : Form
    {
        public AnaSayfa()
        {
            InitializeComponent();
        }

        public EntityKullanici kullanici;
        
        public void KayitlariTabloyaAktar()
        {
            List<EntityKayitDefteri> kayitlar = LogicKayitDefteri.KayitDefteriKayitlariGetir(kullanici);
            dataGridView1.DataSource = kayitlar;
            if(kayitlar != null)
            {
                dataGridView1.Columns["Id"].Visible = false;
                dataGridView1.Columns["SahipId"].Visible = false;
            }
        }


        private void AnaSayfa_Load(object sender, EventArgs e)
        {
            kullanici = LogicKullanici.kullaniciVerileriTamamla(kullanici);
            Foto.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\..\\..\\..\\Photos\\" + kullanici.FotografAdres);
            TxtAd.Text = kullanici.Ad + " " + kullanici.Soyad;
            KayitlariTabloyaAktar();

        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            List<EntityKayitDefteri> kayitlar = LogicKayitDefteri.KayitDefteriKayitlariGetir(kullanici);
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            var kayit = kayitlar[secilen];
            KayitDetay kayitDetay = new KayitDetay();
            KayitDetay.kayit = kayit;
            KayitDetay.kullanici = kullanici;
            kayitDetay.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            KayitlariTabloyaAktar();
        }

        private void BtnEkle_Click(object sender, EventArgs e)
        {
            KayitEkle kayitEkle = new KayitEkle();
            kayitEkle.sahipId = kullanici.Id;
            kayitEkle.Show();
        }
    }
}
