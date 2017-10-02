using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.ViewModels
{
    public class CariHesapViewModel
    {
        public int CariKod { get; set; }
        public string Unvan { get; set; }
        public byte[] FirmaLogo { get; set; }
        public string GrupAdi { get; set; }
        public string CepTel { get; set; }
        public string Ilgili1 { get; set; }
    }
}
