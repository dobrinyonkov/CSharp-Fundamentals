//solved 100/100
using System;
using System.Linq;

namespace Problem_2___The_Horror
{
    class Program
    {
        static void Main()
        {
            string digits = Console.ReadLine();

            int index = 0;
            int sum = 0;
            int counter = 0;

            foreach (char digit in digits)
            {
                if (index % 2 == 0)
                {
                    if (char.IsDigit(digit))
                    {
                        sum += digit - '0';
                        counter++;
                    }

                }
                index++;
            }
            Console.WriteLine("{0} {1}", counter, sum);
        }
    }
}
