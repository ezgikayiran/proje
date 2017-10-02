using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    //bir sınıfı belli alan ve davranışlara zorlamakta kullandığımız yapıdır.
    //abstractan en önemli farkı miras alma sayı sınırına takılmaz.
    //istediğimiz kadar interfaceden miras alabiliriz.
    //içinde access modifier tanımlayamayız. çünkü herşey default publictir.
    //interface değişken tipi olarak kullanılabilir.
    //interface içinde sadece metod imzası tanımlanabilir. gövde olmaz. 
    interface IRepository<T>
    {
        void Ekle(T eklenecekSey); //metod imzası
        void Sil(T silinecekSey); //method signature
    }
}
