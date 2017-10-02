using BusinessLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation
{
    static class Program
    {
        public static CariRepository CariRep = new CariRepository();
        public static GrupRepository GrupRep = new GrupRepository();
        public static HareketRepository HareketRep = new HareketRepository();

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new GirisEkran());
        }
        public static void EkranGuncelle(string FormAdi)
        {
            try
            {
                IGuncelle f = (IGuncelle)Application.OpenForms[FormAdi];
                if (f != null & f is IGuncelle) f.Guncelleme();
            }
            catch { }


        }
        public static void EkranGuncelle()
        {
          
          
             foreach (var item in Application.OpenForms)
                if (item is IGuncelle)
                    ((IGuncelle)item).Guncelleme();
          
         


        }
    }
}
