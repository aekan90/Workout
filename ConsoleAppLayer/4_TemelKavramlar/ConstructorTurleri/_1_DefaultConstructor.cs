using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppLayer._4_TemelKavramlar.ConstructorTurleri
{
    internal class _1_DefaultConstructor
    {
        // MyClass sınıfından bir nesne oluşturma
        MyClass myObject = new MyClass();
    }

    class MyClass
    {
        // Varsayılan constructor (parametre almaz)
        public MyClass()
        {
            // Constructor gövdesi
        }
    }


//      Default Constructor(Varsayılan Constructor):
//Bir sınıfın herhangi bir constructor tanımlanmadığında, varsayılan olarak bir default constructor bulunur.
//Varsayılan constructor, parametre almaz ve sınıfın örneklenmesi durumunda otomatik olarak çağrılır.
//Başka bir constructor tanımlandığında, varsayılan constructor otomatik olarak oluşturulmaz.


}
