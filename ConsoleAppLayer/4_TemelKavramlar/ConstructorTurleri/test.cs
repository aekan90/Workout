using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppLayer._4_TemelKavramlar.ConstructorTurleri
{
    public class test
    {
        public test(int a)
        {
            Console.WriteLine("asd");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            test t= new test(1);
        }
    }
}