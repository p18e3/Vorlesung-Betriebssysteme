using System;
using System.Threading;

namespace VlBetriebssysteme.Threads
{
    class Program
    {
        static volatile int credit = 0;

        static void Main(string[] args)
        {
            Thread thread1 = new Thread(ProcessThread1);
            Thread thread2 = new Thread(ProcessThread2);

            thread1.Start();
            thread2.Start();

            // thread1.Join();
            // thread2.Join();

            System.Console.WriteLine($"Credit is: {credit}");
            Console.ReadLine();
        }
        static void ProcessThread1()
        {
            credit += 20;        
            System.Console.WriteLine($"Thread 1 | Credit has value: {credit}");
        }

        static void ProcessThread2()
        {
            credit += 21;
            System.Console.WriteLine($"Thread 2 | Credit has value: {credit}");
        }
    }
}