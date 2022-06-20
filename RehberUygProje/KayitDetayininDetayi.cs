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
    public partial class KayitDetayininDetayi : Form
    {
        public KayitDetayininDetayi()
        {
            InitializeComponent();
        }

        public EntityKayitDetay detay;

        private void KayitDetayininDetayi_Load(object sender, EventArgs e)
        {
            TxtValueType.Text = detay.ValueType;
            TxtValueName.Text = detay.ValueName; 
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            detay.ValueType = TxtValueType.Text;
            detay.ValueName = TxtValueName.Text;
            if (LogicKayitDetay.KayitDetayGuncelle(detay))
            {
                MessageBox.Show("Kayıt Başarılı!");
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kayıt Başarısız!..");
            }
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            if (LogicKayitDetay.KayitDetaySil(detay))
            {
                MessageBox.Show("Silme Başarılı!");
                this.Hide();
            }
            else
            {
                MessageBox.Show("Silme Başarısız!..");
            }
        }
    }
}
