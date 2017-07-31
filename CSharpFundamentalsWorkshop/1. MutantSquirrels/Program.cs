//solved 100/100

using System;

namespace _1.Mutant_Squirrels
{
    class Program
    {
        static void Main(string[] args)
        {
            ulong t = ulong.Parse(Console.ReadLine()); //number of trees
            ulong b = ulong.Parse(Console.ReadLine());  //number of branches on each tree.
            ulong s = ulong.Parse(Console.ReadLine());  //number of squirrels on each branch.
            ulong n = ulong.Parse(Console.ReadLine());  // average number of tails for each squirrel.

            double product = t * b * s * n;

            if (product % 2 == 0)
            {
                product *= 376439;
            }
            else
            {
                product /= 7.0;
            }
            Console.WriteLine("{0:F3}", product);

        }
    }
}
