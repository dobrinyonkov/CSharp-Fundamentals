//solved 100/100

using System;

namespace Speeds
{
    class Program
    {
        static void Main()
        {
            int numberOfBusses = int.Parse(Console.ReadLine());
            int oldBus = int.Parse(Console.ReadLine());
            int groups = 1;

            for (int i = 0; i < numberOfBusses - 1; i++)
            {
                int currentBus = int.Parse(Console.ReadLine());

                if (currentBus <= oldBus)
                {
                    oldBus = currentBus;
                    groups++;
                }

            }
            Console.WriteLine(groups);
        }
    }
}