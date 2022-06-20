using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LogicLayer;
using DataAccessLayer;
using EntityLayer;

namespace RehberUygProje
{
    public partial class BasarisizGirisler : Form
    {
        public BasarisizGirisler()
        {
            InitializeComponent();
        }

        public List<EntityYalnisGirisLog> logicYalnisGirisLoglar = new List<EntityYalnisGirisLog>();

        private void BasarisizGirisler_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = logicYalnisGirisLoglar;

            LogicYalnisGirisLog.YalnisGirisSilKontrol(logicYalnisGirisLoglar);

        } 
    }
}
