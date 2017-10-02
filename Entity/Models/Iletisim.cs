using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Models
{
    public class Iletisim : Contact
    {
        public string Eposta { get; set; }
        public string Web { get; set; }
        public string Ilgili1 { get; set; }
        public string Ilgili2 { get; set; }
    }
}
