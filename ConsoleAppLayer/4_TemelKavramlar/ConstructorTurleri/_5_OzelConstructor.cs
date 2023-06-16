using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppLayer._4_TemelKavramlar.ConstructorTurleri
{
    internal class _5_OzelConstructor
    {
        // Singleton sınıfından bir nesne oluşturma (Özel constructor'a dışarıdan erişilemez)
        Singleton obj = Singleton.GetInstance();
    }
    class Singleton
    {
        private static Singleton instance;

        // Özel constructor (private erişim belirleyici)
        private Singleton()
        {
            // Constructor gövdesi
        }

        public static Singleton GetInstance()
        {
            if (instance == null)
            {
                instance = new Singleton();
            }
            return instance;
        }
    }



}
