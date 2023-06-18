using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleAppLayer._4_TemelKavramlar.Field_Property_Encapsulation
{
    internal class Field_Property_Encaspsulation
    {
        public class Program
        {

            private string name = "";



            public string Name  // auto-implemented property
            {
                get { return name; }
                set { name = value; }
            }


            // -----------------------------------------

            private string name1 { get; set; } = "atıf"; // backing field'
            name1= "atıf";

            public void UpdateName(string newName)
            {
                // name1 özelliğini güncelleme
                name1 = newName;
            }

        }

        static void Main(string[] args)
        {
            Program program = new Program();
            program.name1 = "asd";
            Console.WriteLine( new Program().name1);


        }


        class InsanEntity
        {
            public string Adi { get; set; } = "Gençay";
            public string Soyadi { get; set; } = "Yıldız";
            public int Yasi { get; set; } = 23;

            public string Cinsiyeti { get; } = "Erkek"; // Auto Property Initializers : set yokken bile ilk değer atayabiliyoruz

            Cinsiyeti="Kadın";

        }
    }
