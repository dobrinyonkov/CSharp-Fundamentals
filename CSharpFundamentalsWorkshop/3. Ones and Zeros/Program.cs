//solved 100/100

using System;

class Program
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        string bin = Convert.ToString(number, 2).PadLeft(32, '0');

        string[] one = { ".#.",
                         "##.",
                         ".#.",
                         ".#.",
                         "###" };

        string[] zero = { "###",
                          "#.#",
                          "#.#",
                          "#.#",
                          "###" };

        for (int row = 0; row < 5; row++)
        {
            for (int i = 16; i < bin.Length; i++)
            {
                if (bin[i] == '0')
                {
                    Console.Write(zero[row]);
                }
                else
                {
                    Console.Write(one[row]);
                }

                if (i != bin.Length - 1)
                {
                    Console.Write(".");
                }
            }
            Console.WriteLine();
        }
    }
}