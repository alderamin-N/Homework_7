using System.Diagnostics;

namespace Homework_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Реализовать метод нахождения n-го члена последовательности Фибоначчи по формуле F(n) = F(n-1) + F(n-2) с помощью рекурсивных вызовов.
            //Реализовать метод нахождения n-го члена последовательности Фибоначчи по формуле F(n) next = current F(n-1) + prev F(n-2) с помощью цикла.
            var stopWatch = new Stopwatch();
            stopWatch.Start();
            int fib1 = Fibonachi(5);
            stopWatch.Stop();
            Console.WriteLine($"5 число Фибоначчи = {fib1}");
            Console.WriteLine("Выполнение рекурсивного метода заняло " + stopWatch.Elapsed.TotalMilliseconds);
            stopWatch.Reset();
           
            stopWatch.Start();
            int fib2 = Fibonachi(10);
            stopWatch.Stop();
            Console.WriteLine($"10 число Фибоначчи = {fib2}");
            Console.WriteLine("Выполнение рекурсивного метода заняло " + stopWatch.Elapsed.TotalMilliseconds);
            stopWatch.Reset();

            stopWatch.Start();
            int fib3 = Fibonachi(20);
            stopWatch.Stop();
            Console.WriteLine($"20 число Фибоначчи = {fib3}");
            Console.WriteLine("Выполнение рекурсивного метода заняло " + stopWatch.Elapsed.TotalMilliseconds);
            stopWatch.Reset();
          
            Console.WriteLine(new string ('-',50));
            stopWatch.Start();
            fib1 = FibonachiLoop(5);
            stopWatch.Stop();
            Console.WriteLine($"5 число Фибоначчи = {fib1}");
            Console.WriteLine("Выполнение итеративного метода заняло " + stopWatch.Elapsed.TotalMilliseconds);
            stopWatch.Reset();

            stopWatch.Start();
            fib2 = FibonachiLoop(10);
            stopWatch.Stop();
            Console.WriteLine($"10 число Фибоначчи = {fib2}");
            Console.WriteLine("Выполнение итеративного метода заняло " + stopWatch.Elapsed.TotalMilliseconds);
            stopWatch.Reset();

            stopWatch.Start();
            fib3 = FibonachiLoop(20);
            stopWatch.Stop();
            Console.WriteLine($"20 число Фибоначчи = {fib3}");
            Console.WriteLine("Выполнение итеративного метода заняло " + stopWatch.Elapsed.TotalMilliseconds);
            stopWatch.Reset();
        }       
       private static int Fibonachi(int n)
        {
            if (n is 0 or 1)
            {
                return n;
            }        
            return Fibonachi(n - 1) + Fibonachi(n - 2);
        }
        private static int FibonachiLoop(int n)
        {
            int next = 0;
            int prev = 0;
            int current = 1;
            if (n is 0 or 1)
            {
                return n;
            }                       
            for (int i = 2; i <= n; i++)
            {
                next = current + prev;
                prev = current;
                current = next;               
            }
            return next;
        }
    }
}