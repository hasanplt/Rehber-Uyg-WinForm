using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class EntityKayitDefteri
    {
        private int id;
        private string isim;
        private string numara;
        private int sahipId;

        public int Id { get => id; set => id = value; }
        public string Isim { get => isim; set => isim = value; }
        public string Numara { get => numara; set => numara = value; }
        public int SahipId { get => sahipId; set => sahipId = value; }
    }
}
