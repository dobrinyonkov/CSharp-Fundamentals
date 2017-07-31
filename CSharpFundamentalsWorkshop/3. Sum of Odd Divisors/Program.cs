//solved 100/100

using System;

namespace _3.Sum_of_Even_Divisors
{
    class Program
    {
        static void Main()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            int sumOfSums = 0;

            for (int i = a; i <= b; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    if (i % j == 0 && !(j % 2 == 0))
                    {
                        sumOfSums += j;
                    }

                }
            }
            Console.WriteLine(sumOfSums);
        }
    }
}