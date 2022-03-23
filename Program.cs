using System;

namespace MinUndMax
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Number of elements? ");
            int n = int.Parse(Console.ReadLine());

            Console.Write("1 st element: ");
            int max = int.Parse(Console.ReadLine());
            int min = max;
            for (int i = 2; i <= n; ++i)
            {
                Console.Write($"{i} element? ");
                int cur = int.Parse(Console.ReadLine());
                if (cur > max)
                {
                    max = cur;
                }
                else if (cur < min)
                {
                    min = cur;
                }
            }
            Console.WriteLine($"Maximum: {max}. \nMinimum: {min}.");
        }
    }
}
