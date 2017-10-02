using Entity.Models;
using System;
using System.IO;
using System.Windows.Forms;

namespace Presentation
{
    public partial class YeniCariHesapEkran : Form,IGuncelle
    {
  
        public YeniCariHesapEkran()
        {
            InitializeComponent();
        }

        private void btn_Kaydet_Click(object sender, EventArgs e)
        {
            CariHesap yeniHesap = new CariHesap();

            #region Genel
            yeniHesap.Unvan = txt_Unvan.Text;
            yeniHesap.Grup = (Grup)cmb_Grup.SelectedItem;
            if (!string.IsNullOrEmpty(p_Resim.ImageLocation))
                yeniHesap.FirmaLogo = File.ReadAllBytes(p_Resim.ImageLocation);
            #endregion

            #region Ticari
            /*
            yeniHesap.Ticari = new Ticari();
            yeniHesap.Ticari.SahisFirmasi = chk_SahisFirma.Checked;
            */

            Ticari t = new Ticari();
            t.SahisFirmasi = chk_SahisFirma.Checked;
            t.YabanciUyruk = chk_YabanciUyruk.Checked;
            try //Scope içindeki kodları çalıştırmayı dene
            {
                t.VergiNo = Convert.ToInt64(msk_VergiNo.Text);
            }
            catch { } //hata çıkarsa hiçbir iş yapma

            //çevir ve aktar
            // t.TCKimlikNo = Convert.ToInt64(msk_TC.Text);
            long gecici;
            long.TryParse(msk_TC.Text, out gecici);
            t.TCKimlikNo = gecici;

            t.KDVNo = txt_KDVNo.Text;
            yeniHesap.Ticari = t;
            #endregion

            #region Iletisim
            yeniHesap.Iletisim = new Iletisim();
            yeniHesap.Iletisim.Adres = txt_IletisimAdres.Text;
            yeniHesap.Iletisim.CepTel = msk_IletisimCep.Text;
            yeniHesap.Iletisim.Tel = msk_IletisimTel.Text;
            yeniHesap.Iletisim.Eposta = txt_IletisimEmail.Text;
            yeniHesap.Iletisim.Web = txt_IletisimWeb.Text;
            yeniHesap.Iletisim.Ilgili1 = txt_Ilgili1.Text;
            yeniHesap.Iletisim.Ilgili2 = txt_Ilgili2.Text;
            #endregion

            #region Kefil 
            yeniHesap.Kefil = new Kefil();
            yeniHesap.Kefil.Adres = txt_KefilAdres.Text;
            yeniHesap.Kefil.AdSoyad = txt_KefilAdSoyad.Text;
            yeniHesap.Kefil.CepTel = msk_KefilCep.Text;
            yeniHesap.Kefil.Tel = msk_KefilTel.Text;
            #endregion

            #region Banka
            yeniHesap.Banka = new Banka();
            yeniHesap.Banka.BankaAdi = txt_BankaAd.Text;
            yeniHesap.Banka.HesapNo = txt_BankaHesapNo.Text;
            yeniHesap.Banka.IBAN = msk_BankaIban.Text;
            yeniHesap.Banka.SubeAdi = txt_BankaSubeAd.Text;
            yeniHesap.Banka.SubeKodu = txt_BankaSubeKod.Text;
            #endregion

            Program.CariRep.Ekle(yeniHesap);

            Program.EkranGuncelle("CariHesaplarListe");

        }

        private void btn_ResimSec_Click(object sender, EventArgs e)
        {
            OpenFileDialog o1 = new OpenFileDialog();
            o1.Title = "Firma logosu seç";
            o1.Filter = "Resim (.png, .jpg) |*.png;*.jpg";
            o1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
            if (o1.ShowDialog() == DialogResult.OK)
                p_Resim.ImageLocation = o1.FileName;

        }

         void GrupListeGuncelle()
        {
            // cmb_Grup.Items.Add(g);
            cmb_Grup.DataSource = null;
            cmb_Grup.DataSource = Program.GrupRep.Liste;
            cmb_Grup.DisplayMember = "GrupAdi";
        }

        private void YeniCariHesapEkran_Load(object sender, EventArgs e)
        {
            GrupListeGuncelle();
            chk_SahisFirma_CheckedChanged(chk_SahisFirma, e);
        }

        private void chk_SahisFirma_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_SahisFirma.Checked)
            {
                msk_TC.Enabled = true;
                msk_VergiNo.Enabled = false; //disabled
            }
            else
            {
                msk_TC.Enabled = false;
                msk_VergiNo.Enabled = true;
            }
        }

        public void Guncelleme()
        {
            GrupListeGuncelle();
        }
    }
}
