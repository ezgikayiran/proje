using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation
{
    public partial class GirisEkran : Form,IGuncelle
    {
        public GirisEkran()
        {
            InitializeComponent();
        }

        private void btn_CariHesaplar_Click(object sender, EventArgs e)
        {
            new CariHesaplarListe().Show();
        }

        private void menu_Gruplar_Click(object sender, EventArgs e)
        {
            new GrupListe().Show();
        }

        private void GirisEkran_Load(object sender, EventArgs e)
        {
            Guncelleme();
        }

        public void Guncelleme()
        {
            //lbl_BorcToplam.Text = Program.HareketRep.Liste.Where(x => x.IslemTipi == Entity.Models.IslemTipi.NakitTahsilat).Sum(x => x.Tutar).ToString();
            //lbl_AlacakToplam.Text = Program.HareketRep.Liste.Where(x => x.IslemTipi == Entity.Models.IslemTipi.NakitTahsilat).Sum(x => x.Tutar).ToString();
            decimal tediyeToplam = 0;
            decimal tahsilatToplam = 0;
            foreach (var item in Program.HareketRep.Liste)
            {
                if (item.IslemTipi == Entity.Models.IslemTipi.NakitTediye)
                    tediyeToplam += item.Tutar;
                else
                    tahsilatToplam += item.Tutar;
                lbl_AlacakToplam.Text = tahsilatToplam.ToString();
                lbl_BorcToplam.Text = tediyeToplam.ToString();

                decimal toplam = tediyeToplam + tahsilatToplam;
                lbl_NakitEkran.Text = toplam.ToString();
            }
        }
    }
}
