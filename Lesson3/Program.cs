using System;
using System.Threading;

namespace Lesson3
{
    class MainClass
    {
        public static void Main(string[] args)
    {
            Thread tr1 = new Thread(() => ThreadFunctionFibonachi(12));
            tr1.Start();
        Console.WriteLine("The main thread!");
    }

    static void ThreadFunctionFibonachi(int number)
    {
  Console.WriteLine("The child thread!");
            if (number >= 1)
            {
                var first = 1;
                var second = 1;
                var sum = 0;
                int j = 2;
                while (j <= number)
                {
                    sum = first + second;
                    first = second;
                    second = sum;
                    j++;
                }
                Console.WriteLine("Your number: " + number + " => Fibonachi result: " + first);
            }
            else
            {
                Console.WriteLine($"Your number: {number} not found in fibonachi program=(");
            }
        }
    }
}
