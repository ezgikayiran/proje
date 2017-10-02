using Entity.Models;
using Entity.ViewModels;
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
    public partial class HesapHareketListe : Form, IGuncelle
    {
        public CariHesap SecilenCariHesap { get; set; }
        public HesapHareketListe()
        {
            InitializeComponent();

        }
        void FillDataGrid()
        {
            List<HesapHareketViewModel> ozetListe;
            if (SecilenCariHesap == null)
                ozetListe = Program.HareketRep.HesapHareketOzetListe();
            else
                ozetListe = Program.HareketRep.CariHareketleriOzet(SecilenCariHesap.CariKod);
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = ozetListe;
        }
        private void HesapHareketListe_Load(object sender, EventArgs e)
        {
            FillDataGrid();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //dataGridView1.SelectionMode = SelectionMode.FullRowSelect;

            //Silmek istediğiniz hesap hareketini seçiniz.

            // .... İşletmeye ait ..... tutarındaki hesap hareketini silmek istediğinize emin misiniz?

            //Eğer evet derse ilgili rep nesnesinin Sil metodunu çağıralım.

            //seçili satırların sayısı 0 sa
            if (dataGridView1.SelectedRows.Count == 0)
                MessageBox.Show("Silinecek hesap hareketini seçiniz.");
            else
            {   //silinecek şeyler var
                foreach (DataGridViewRow item in dataGridView1.SelectedRows)
                {
                    HesapHareketViewModel silinecek = (HesapHareketViewModel)item.DataBoundItem;
                    Program.HareketRep.Sil(silinecek);

                }
                Program.EkranGuncelle();
            }

        }

        public void Guncelleme()
        {
            FillDataGrid();
        }
    }
}
