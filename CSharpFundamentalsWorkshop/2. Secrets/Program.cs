//solved 100/100

using System;
using System.Numerics;

namespace Problem_2___The_Secrets_of_Numbers
{
    class Program
    {
        static void Main()
        {
            string text = Console.ReadLine();

            string reversedText = "";

            BigInteger sum = 0;
            int index = 1;

            for (int i = text.Length - 1; i >= 0; i--)
            {
                reversedText += text[i];
            }
            foreach (char symbol in reversedText)
            {
                if (symbol == '-')
                {
                    continue;
                }
                int number = symbol - '0';

                if (index % 2 == 0)
                {
                    sum += (number * number) * index;
                }
                else
                {
                    sum += number * (index * index);

                }
                index++;
            }

            Console.WriteLine(sum);

            int length = (int)sum % 10;
            if (length == 0)
            {
                Console.WriteLine("{0} has no secret alpha-sequence", text);
            }
            int r = (int)sum % 26;
            for (int i = 0; i < length; i++)
            {
                Console.Write((char)('A' + (r + i) % 26));
            }
            Console.WriteLine();
        }
    }
}
