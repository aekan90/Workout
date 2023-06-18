using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleAppLayer._4_TemelKavramlar.ConstructorTurleri
{
    internal class _5_OzelConstructor
    {
        
    }
     public class Personal
    {

        private string Name1 { get; set; } // Property
        private string Name2;
        
       

        private string Name { get; set; }
        private int Age { get; set; }

        public string GetName()
        {
            return Name;
        }

        private Personal()
        {
            // Private constructor
        }

        public static Personal CreateAdult(string name)
        {
            return new Personal { Name = name, Age = 18 };
        }

        public static Personal CreateChild(string name)
        {
            return new Personal { Name = name, Age = 10 };
        }
    }

    class Program
    {
        //static void Main(string[] args)
        //{

        //    Personal adult = Personal.CreateAdult("John");
        //    adult.Name1;
        //    adult.Name2;
        //    Console.WriteLine(adult.GetName); // John
        //    Console.WriteLine(adult.Age); // 18

        //    Personal child = Personal.CreateChild("Alice");
        //    Console.WriteLine(child.Name); // Alice
        //    Console.WriteLine(child.Age); // 10
        //}
    }



}
