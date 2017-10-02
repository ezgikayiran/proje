using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Models
{
   public class Banka
    {
        public string BankaAdi { get; set; }
        public string SubeAdi { get; set; }
        public string SubeKodu { get; set; }
        public string HesapNo { get; set; }
        public string IBAN { get; set; }
        public Sehir Sehir { get; set; }
        public Ilce Ilce { get; set; }
    }
}
