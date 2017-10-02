using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Models
{
    public class Ticari
    {
        public bool YabanciUyruk { get; set; }
        public bool SahisFirmasi { get; set; }
        public long TCKimlikNo { get; set; }
        public long VergiNo { get; set; }
        public string VergiDairesi { get; set; }
        public string KDVNo { get; set; }
    }
}
