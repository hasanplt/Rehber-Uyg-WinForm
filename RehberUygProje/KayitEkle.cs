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
    public partial class KayitEkle : Form
    {
        public KayitEkle()
        {
            InitializeComponent();
        }
        public int sahipId;
        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            EntityKayitDefteri kayit = new EntityKayitDefteri();
            kayit.Isim = TxtIsim.Text;
            kayit.Numara = TxtNumara.Text;
            kayit.SahipId = sahipId;
            if (LogicKayitDefteri.KayitEkle(kayit))
            {
                this.Hide();
                MessageBox.Show("Başarıyla Eklendi!");
            }
            else
            {
                MessageBox.Show("Lütfen tüm alanları doldurunuz! Veri Eklenemedi...");
            }

        }
    }
}
