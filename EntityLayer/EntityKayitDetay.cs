using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class EntityKayitDetay
    {
        private int id;
        private string valueType;
        private string valueName;
        private int kayitDefteriId;

        public int Id { get => id; set => id = value; }
        public string ValueType { get => valueType; set => valueType = value; }
        public string ValueName { get => valueName; set => valueName = value; }
        public int KayitDefteriId { get => kayitDefteriId; set => kayitDefteriId = value; }
    }
}
