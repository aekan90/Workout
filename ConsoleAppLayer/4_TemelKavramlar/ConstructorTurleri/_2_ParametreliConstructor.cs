using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppLayer._4_TemelKavramlar.ConstructorTurleri
{
    internal class _2_ParametreliConstructor
    {
        // Person sınıfından bir nesne oluşturma ve başlangıç değerlerini ayarlama
        Person person = new Person("John Doe", 30);
    }
    class Person
    {
        public string Name;
        public int Age;

        // Parametreli constructor
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }

//    Parametreli Constructor:
//Parametreli constructor'lar, bir veya daha fazla parametre alır.
//Parametreler, nesnenin oluşturulması ve başlangıç durumunun ayarlanması için kullanılır.
//Sınıfın birden fazla parametreli constructor'ı olabilir ve farklı parametre listeleriyle ayrı ayrı tanımlanabilir.

}
