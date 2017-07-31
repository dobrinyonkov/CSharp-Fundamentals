//solved 100/100

using System;

namespace problem3
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];

            for (int i = 0; i < n; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i <= n - 2;)
            {
                int num = array[i] % 10;
                int num2 = array[i += 1] / 10;
                int product = num * num2;
                Console.Write("{0} ", product);
            }
            Console.WriteLine();
            for (int i = 0; i <= n - 2;)
            {
                int num = array[i];
                int num2 = array[i += 1];
                int substract = num - num2;
                if (substract < 0)
                {
                    substract *= -1;
                }
                Console.Write("{0} ", substract);
            }
            Console.WriteLine();
        }
    }
}
