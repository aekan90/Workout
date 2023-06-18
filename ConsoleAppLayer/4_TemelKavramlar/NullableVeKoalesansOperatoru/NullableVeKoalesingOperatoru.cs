using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppLayer.TemelKavramlar
{
    public class NullableVeKoalesingOperatoru
    {
        public static void metot()
        {
            // Nullable int (int?) kullanımı
            int? nullableInt = null;
            Console.WriteLine("Output:"+nullableInt.HasValue); // Output: null

            nullableInt = 5;
            Console.WriteLine("Output:" + nullableInt); // Output: 5

            int regularInt = nullableInt ?? 0; // nullableInt null ise 0, değilse nullableInt'in değeri atanır (Koalesing Operatörü)
            Console.WriteLine("Output:" + regularInt); // Output: 5

        }

        //static void Main(string[] args)
        //{
        //    metot();
        //}
    }
}
