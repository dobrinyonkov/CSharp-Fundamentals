//solved 100/100

using System;

namespace Problem_1___Peace_of_Cake
{
    class Program
    {
        static void Main()
        {
            long a = long.Parse(Console.ReadLine());
            long b = long.Parse(Console.ReadLine());
            long c = long.Parse(Console.ReadLine());
            long d = long.Parse(Console.ReadLine());


            decimal totalAmountCakes = (decimal)a / b + (decimal)c / d;



            if (totalAmountCakes >= 1)
            {
                Console.WriteLine((int)totalAmountCakes);
            }
            else
            {
                Console.WriteLine("{0:f22}", totalAmountCakes);
            }

            Console.WriteLine("{0}/{1}", a * d + b * c, b * d);

        }
    }
}
