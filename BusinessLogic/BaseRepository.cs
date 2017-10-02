using DAL;
using Entity.Models;
using System;
using System.Collections.Generic;

namespace BusinessLogic
{
    public class BaseRepository<T> : IRepository<T> where T : class
    {
        public List<T> Liste;
        public void Ekle(T eklenecekSey)
        {
            if(eklenecekSey is CariHesap)
                (eklenecekSey as CariHesap).CariKod = Liste.Count + 1;

            else if(eklenecekSey is Grup)
                (eklenecekSey as Grup).GrupKodu = Liste.Count + 1;

            else if(eklenecekSey is HesapHareket)
                (eklenecekSey as HesapHareket).HesapHareketKod = Liste.Count + 1;

            Liste.Add(eklenecekSey);

            //Dosyaya kaydet
            //BusinessLogic'te DAL için referans ekleyelim
            //Kaydet metoduna eklenecekSey parametresini gönderin.

            //Kaydet metodunu statiğe çevirip ona göre çağıralım
            //Kayit sınıfından üretilebilecek nesneler arasında fark olmayacağından kolay erişimi tercih ettik.
            Kayit<T>.Kaydet(Liste);
        }
        public void Sil(T silinecekSey)
        {
            Liste.Remove(silinecekSey);
            Kayit<T>.Kaydet(Liste);
        }
        
        private void Listele()
        {
            //T: CariHesap.cs | Grup.cs
            Liste = Kayit<T>.Oku();
        }

        public BaseRepository() //uygulama açılırken Program.cs içerisinde new ile inşa edildiğinde tüm listeleri hazırlayıp getirir.
        {
            Listele();
            if (Liste == null) Liste = new List<T>();
        }
          

    }
}
