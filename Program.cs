using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MyTimer
{
    internal class Program
    {
        static int currentNum = 0;
        static int a = 0;
        static int b = 1;
        static void Main(string[] args)
        {
            int fibanachiMax = 20;
            TimerCallback timerCallback = new TimerCallback(FibanachiTimer);
            Timer timer = new Timer(timerCallback, fibanachiMax, 0,500);
            while (currentNum < fibanachiMax)
            {
                Thread.Sleep(500);
            }
            timer.Dispose();
            Console.WriteLine("We are done!");

            Console.ReadLine();
        }
        static void FibanachiTimer(object state)
        {
            Console.WriteLine(b);
            currentNum++;
            int tmp = b;
            b = a + b;
            a = tmp;
        }
    }
}
