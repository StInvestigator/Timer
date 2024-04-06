using System;
using System.Threading;

namespace MyTimer
{
    internal class Program
    {
        static int currentNum = 0;
        static int a = 0;
        static int b = 1;
        static void Main(string[] args)
        {
            Console.WriteLine("Enter max fibanachi number: ");
            try
            {
                int fibanachiMax = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("We are starting...");
                TimerCallback timerCallback = new TimerCallback(FibanachiTimer);
                Timer timer = new Timer(timerCallback, fibanachiMax, 0,500);
                while (currentNum < fibanachiMax)
                {
                    Thread.Sleep(500);
                }
                timer.Dispose();
                Console.WriteLine("We are done!");
                }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadLine();
        }
        static void FibanachiTimer(object state)
        {
            Console.WriteLine(a);
            currentNum++;
            int tmp = b;
            b = a + b;
            a = tmp;
        }
    }
}
