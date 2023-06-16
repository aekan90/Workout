using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppLayer._4_TemelKavramlar.ConstructorTurleri
{
    public class _3_CopyConstructor
    {

        public void CopyPerson()
        {
            // Person nesnesi oluşturma
            Person originalPerson = new Person { Name = "John Doe", Age = 30 };

            // Başka bir nesnenin değerlerini kopyalama
            Person copiedPerson = new Person(originalPerson);

            // Değerleri yazdırma
            Console.WriteLine("Original Person: Name={0}, Age={1}", originalPerson.Name, originalPerson.Age);
            Console.WriteLine("Copied Person: Name={0}, Age={1}", copiedPerson.Name, copiedPerson.Age);
        }


        public class Person
        {
            public string Name;
            public int Age;

            public Person()
            {
            }

            // Kopyalama constructor
            public Person(Person other)
            {
                Name = other.Name;
                Age = other.Age;
            }

            // Parametresiz constructor

        }

    }
}
