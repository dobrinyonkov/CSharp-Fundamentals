//solved 100/100

using System;

namespace Problem_1___Garden
{
    class Program
    {
        static void Main()
        {
            int t = int.Parse(Console.ReadLine());
            int tarea = int.Parse(Console.ReadLine());

            int c = int.Parse(Console.ReadLine());
            int carea = int.Parse(Console.ReadLine());

            int p = int.Parse(Console.ReadLine());
            int parea = int.Parse(Console.ReadLine());

            int carrot = int.Parse(Console.ReadLine());
            int carrotarea = int.Parse(Console.ReadLine());

            int cab = int.Parse(Console.ReadLine());
            int cabarea = int.Parse(Console.ReadLine());

            int b = int.Parse(Console.ReadLine());

            double tprice = t * 0.5;
            double cprice = c * 0.4;
            double pprice = p * 0.25;
            double carrotprice = carrot * 0.6;
            double cabprice = cab * 0.3;
            double bprice = b * 0.4;

            double totalprice = tprice + cprice + pprice + carrotprice + cabprice + bprice;


            int totalarea = 250;
            int areaneeded = tarea + carea + parea + carrotarea + cabarea;

            Console.WriteLine("Total costs: {0:f2}", totalprice);
            if (totalarea > areaneeded)
            {
                totalarea -= areaneeded;
                Console.WriteLine("Beans area: {0}", totalarea);
            }
            else if (totalarea < areaneeded)
            {
                Console.WriteLine("Insufficient area");
            }
            else
            {
                Console.WriteLine("No area for beans");
            }


        }
    }
}
