//solved 96/100

using System;

namespace _1___Coffee_Vending_Machine
{
    class Program
    {
        static void Main()
        {
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int n3 = int.Parse(Console.ReadLine());
            int n4 = int.Parse(Console.ReadLine());
            int n5 = int.Parse(Console.ReadLine());

            double a = double.Parse(Console.ReadLine());
            double price = double.Parse(Console.ReadLine());

            double m1 = 0.05;
            double m2 = 0.10;
            double m3 = 0.20;
            double m4 = 0.50;
            double m5 = 1.00;

            double inventory = (n1 * m1) + (n2 * m2) + (n3 * m3) + (n4 * m4) + (n5 * m5);

            if (a >= price && a - price < inventory)
            {
                a -= price;
                inventory -= a;
                Console.WriteLine("Yes {0:f2}", inventory);
            }
            else if (price > a)
            {
                price -= a;
                Console.WriteLine("More {0:f2}", price);
            }
            else if (a - price > inventory)
            {
                a -= price;
                a = a - inventory;
                Console.WriteLine("No {0:f2}", a);
            }
        }
    }
}
