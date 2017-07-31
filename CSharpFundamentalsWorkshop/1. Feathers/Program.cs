//solved 100/100

using System;

namespace _1.Birds_and_Feathers
{
    class Program
    {
        static void Main(string[] args)
        {
            double n = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double avg = 0;
            if (n != 0 & b != 0)
            {
                avg = b / n;
            }
            else
            {
                avg = 0;
            }

            if (n % 2 == 0)
            {
                avg *= 123123123123;
            }
            else if (n % 2 != 0)
            {
                avg /= 317;
            }
            Console.WriteLine("{0:f4}", avg);
        }
    }
}