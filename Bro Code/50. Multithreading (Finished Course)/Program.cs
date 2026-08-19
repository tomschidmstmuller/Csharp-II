using System;
using System.Threading;

namespace MyLastProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            // thread = an execution path of a program
            //          We can use multiple threads to perform,
            //          different tasks of our program at the same time.
            //          Current thread running is "main" thread
            //          using System.Threading;

            Thread mainThread = Thread.CurrentThread;
            mainThread.Name = "Main Thread";
            //Console.WriteLine(mainThread.Name);

            Thread thread1 = new Thread(() => CountDown("Timer#1")); // Corrected method invocation
            Thread thread2 = new Thread(() => CountUp("Timer#2")); // Corrected method invocation

            thread1.Start();
            thread2.Start();

            // Since threads are running asynchronously,
            // we don't know when they will finish.
            // So, we should wait for them to complete before printing completion message.
            thread1.Join();
            thread2.Join();

            Console.WriteLine($"{mainThread.Name} is complete!");
        }

        public static void CountDown(string timerName) // Added parameter to match method call
        {
            for (int i = 10; i >= 0; i--)
            {
                Console.WriteLine($"{timerName}: {i} seconds");
                Thread.Sleep(1000);
            }
            Console.WriteLine($"{timerName} is complete!");
        }

        public static void CountUp(string timerName) // Added parameter to match method call
        {
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine($"{timerName}: {i} seconds");
                Thread.Sleep(1000);
            }
            Console.WriteLine($"{timerName} is complete!");
        }
    }
}
