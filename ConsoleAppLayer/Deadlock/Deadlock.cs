namespace ConsoleAppLayer.Deadlock
{   // Deadlock nedir ?= it ite it de kuyruğuna
    public class Deadlock
    {

        static object lock1 = new object();
        static object lock2 = new object();

        public void Method1()
        {

            lock (lock1)
            {
                Console.WriteLine("Method1 lock1'ı kilitleyerek bekliyor...");

                // Method1, lock1'ı kilitleyip lock2'yi bekliyor
                Thread.Sleep(1000);

                lock (lock2)
                {
                    Console.WriteLine("Method1 lock1 ve lock2'yi kilitledi.");
                }
            }
        }

        public void Method2()
        {
            lock (lock2)
            {
                Console.WriteLine("Method2 lock2'yi kilitleyerek bekliyor...");

                // Method2, lock2'yi kilitleyip lock1'i bekliyor
                Thread.Sleep(1000);

                lock (lock1)
                {
                    Console.WriteLine("Method2 lock1 ve lock2'yi kilitledi.");
                }
            }
        }
    }
}


//static void Main(string[] args)
//{
//    Thread thread1 = new Thread(Method1);
//    Thread thread2 = new Thread(Method2);

//    thread1.Start();
//    thread2.Start();

//    // Ana thread'in işlemi bitirebilmesi için diğer thread'lerin tamamlanmasını bekliyoruz
//    thread1.Join();
//    thread2.Join();

//    Console.WriteLine("Program tamamlandı.");
//    Console.ReadLine();
//}