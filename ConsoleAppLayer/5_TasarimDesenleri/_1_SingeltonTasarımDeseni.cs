using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppLayer._5_TasarimDesenleri
{
    internal class _1_SingeltonTasarımDeseni
    {
    }

    public class Singleton
    {
        private static Singleton _instance;

        // Gizli bir constructor
        private Singleton()
        {
        }

        // Singleton örneğine erişim sağlayan property
        public static Singleton Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Singleton();
                }
                return _instance;
            }
        }

        // Diğer sınıfların kullanabileceği bir metot
        public void DoSomething()
        {
            Console.WriteLine("Singleton instance is doing something.");
        }
    }

    class Program
    {
        //static void Main(string[] args)
        //{
        //    Singleton instance1 = Singleton.Instance;
        //    Singleton instance2 = Singleton.Instance;

        //    if (instance1 == instance2)
        //    {
        //        Console.WriteLine("instance1 and instance2 are the same.");
        //    }
        //    else
        //    {
        //        Console.WriteLine("instance1 and instance2 are different.");
        //    }

        //    Console.ReadLine();
        //}
    }




}


