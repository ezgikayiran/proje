using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Models
{
    //Sadece ortak alanlar için oluşturuldu
    //Tam bir varlık değil. Bu yüzden abstract olarak işaretledik.
    public abstract class Contact
    {
        public string Adres { get; set; }
        public Sehir Sehir { get; set; }
        public Ilce Ilce { get; set; }
        public string Tel { get; set; }
        public string CepTel { get; set; }
    }
}
