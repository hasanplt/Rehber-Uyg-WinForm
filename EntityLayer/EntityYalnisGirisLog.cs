using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class EntityYalnisGirisLog
    {
        private int id;
        private DateTime zaman;
        private int kId;

        public int Id { get => id; set => id = value; }
        public DateTime Zaman { get => zaman; set => zaman = value; }
        public int KId { get => kId; set => kId = value; }
    }
}
