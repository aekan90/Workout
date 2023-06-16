using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppLayer._4_TemelKavramlar.ConstructorTurleri
{
    internal class _4_StatikConstructor
    { 
        // Statik constructor çağrılır ve LogFileName özelliği ayarlanır
        string logFile = Logger.LogFileName;
    }

    class Logger
    {
        public static string LogFileName;

        // Statik constructor
        static Logger()
        {
            LogFileName = "log.txt";
        }
    }



}
