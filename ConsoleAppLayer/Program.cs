using ConsoleAppLayer.Deadlock;
using System;
using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Threading;
public static class Program
{
    static List<int> numbers = new List<int>();  // Paylaşılan liste

    static object lockObject = new object();  // Kilitleme için kullanılacak nesne
    static void Main(string[] args)
    {

        Thread thread1 = new Thread(AddNumbers);
        Thread thread2 = new Thread(AddNumbers);

        thread1.Start();
        thread2.Start();

        thread1.Join();
        thread2.Join();

        Console.WriteLine("Sonuç: " + string.Join(", ", numbers));
        Console.ReadLine();

        static void AddNumbers()
        {
            for (int i = 0; i < 10; i++)
            {
                lock (lockObject)  // Liste üzerinde kilitleme
                {
                    int number = i + 1;
                    Console.WriteLine("Thread: " + Thread.CurrentThread.ManagedThreadId + " Eklenen sayı: " + number);
                    numbers.Add(number);
                    Thread.Sleep(100);  // Senkronizasyonu vurgulamak için bir bekleme süresi
                }
            }


            Public List<Hotel> GetAllHotels()
            {
                using (var hotelDbContext=new HotelDbContext())
                {
                    return hotelDbContext.Hotes.ToList();
                }
            }

            //Deadlock deadlock = new Deadlock();
            //Thread thread1 = new Thread(deadlock.Method1);
            //Thread thread2 = new Thread(deadlock.Method2);

            //Console.WriteLine("thread1.Start();");
            //thread1.Start();
            //Console.WriteLine("thread2.Start();");
            //thread2.Start();

            //// Ana thread'in işlemi bitirebilmesi için diğer thread'lerin tamamlanmasını bekliyoruz
            //thread1.Join();
            //Console.WriteLine("thread1.Join();");
            //thread2.Join();
            //Console.WriteLine("thread1.Join();");

            //Console.WriteLine("Program tamamlandı."); // bu satır hiç çalışmaz bu duruma da deadlock denir.
            //Console.ReadLine();
        }

    }
}