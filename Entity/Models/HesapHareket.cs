using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Models
{
    public class HesapHareket
    {
        public int HesapHareketKod { get; set; }
        public CariHesap Carihesap { get; set; }
        public decimal Tutar { get; set; }
        public IslemTipi IslemTipi { get; set; }
        public DateTime IslemTarihi { get; set; }
        public DateTime VadeTarihi { get; set; }
        public int VadeGunu { get; set; }
        public Evrak Evrak { get; set; }
    }

    public class Evrak{
        public string EvrakNo { get; set; }
        public string EvrakTipi { get; set; }
        public string EvrakCinsi { get; set; }
    }
    
    [Flags] //aşağıdaki tipleri sayı olarak değil olduğu gibi kullan
    public enum IslemTipi
    {
        NakitTediye,
        NakitTahsilat
    }
}
