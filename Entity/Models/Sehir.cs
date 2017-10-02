using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Models
{
    public class Sehir
    {
        public int SehirNo { get; set; }
        public string SehirAdi { get; set; }
        public List<Ilce> Ilceler { get; set; }
    }
}
