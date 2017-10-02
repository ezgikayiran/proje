using Entity.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.ViewModels
{
    public class HesapHareketViewModel
    {
        public int HesapHareketKod { get; set; }
        public string Unvan { get; set; }
        public decimal Tutar { get; set; }
        public IslemTipi IslemTipi { get; set; }

        [Browsable(false)] //datasource olarak aktarıldığı yerde gözükmesin
        public DateTime IslemTarihi { get; set; }

        public string Tarih
        {
            get
            {
                return IslemTarihi.ToShortDateString();
            }
        }

        public int CariKod { get; set; }
    }
}
