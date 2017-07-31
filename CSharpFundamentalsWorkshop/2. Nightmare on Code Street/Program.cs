//solved 100/100

using System;
using System.Numerics;

namespace Problem_2___Nightmare_on_Code_Street
{
    class Program
    {
        static void Main(string[] args)
        {

            string number = Console.ReadLine();

            BigInteger sum = 0;
            long index = 0;
            int counter = 0;

            foreach (char symbol in number)
            {
                if (index % 2 == 1 && char.IsDigit(symbol))
                {
                    sum += symbol - '0';
                    counter++;
                }
                index++;
            }
            Console.WriteLine("{0} {1}", counter, sum);
        }
    }
}
