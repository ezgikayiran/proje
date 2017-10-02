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
    public partial class CariHesaplarListe : Form,IGuncelle
    {
        public CariHesaplarListe()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new YeniCariHesapEkran().Show();
        }

        private void CariHesaplarListe_Load(object sender, EventArgs e)
        {
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            Guncelleme();
        }
        
     

        private void button4_Click(object sender, EventArgs e)
        {
            foreach ( DataGridViewRow item in dataGridView1.SelectedRows)
            { //seçili tüm satırları sil
                //item: silinecek datagrid satırı
                string unvan = item.Cells["Unvan"].Value.ToString();
                //..... adlı işletmeyi silmek istediğinize emin misiniz?
                if(MessageBox.Show(unvan + " adlı işletmeyi silmek istediğinize emin misiniz?","Cari Hesap Sil", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Program.CariRep.Sil((CariHesapViewModel)item.DataBoundItem);
                    Program.EkranGuncelle();
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new YeniHesapHareketEkran().Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            new HesapHareketListe().Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            CariHesap secilen = Program.CariRep.Liste[e.RowIndex];
            HesapHareketListe hForm = new HesapHareketListe();
            hForm.SecilenCariHesap = secilen;
            hForm.Show();
        }

        public void Guncelleme()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = Program.CariRep.CariHesapOzetListe();
        }
    }
}
