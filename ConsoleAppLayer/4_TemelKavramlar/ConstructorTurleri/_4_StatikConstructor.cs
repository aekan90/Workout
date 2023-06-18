using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppLayer._4_TemelKavramlar.ConstructorTurleri
{
    internal class _4_StatikConstructor
    {
        class MyClass
        {
            public static int Counter { get; set; }
            public static string Message { get; set; }

            static MyClass()
            {
                Counter = 0;
                Message = "Hello, World!";
                Console.WriteLine("Static constructor is called.");
            }
        }

        class Program
        {
            //static void Main(string[] args)
            //{
            //    Console.WriteLine(MyClass.Counter); // Static constructor is called. 0
            //    Console.WriteLine(MyClass.Message); // Hello, World!
            //    Console.WriteLine(MyClass.Counter); // 0 (Çünkü statik elemanlar bir kez başlatıldı)
            //}
        }

    }




}
