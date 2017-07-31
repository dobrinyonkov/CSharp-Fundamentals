//solved 100/100
using System;

namespace Problem_2___Angry_Female_GPS
{
    class Program
    {
        static void Main()
        {
            string text = Console.ReadLine();

            long sumOdd = 0;
            long sumEven = 0;

            foreach (char symbol in text)
            {
                if (char.IsDigit(symbol))
                {

                    int currentNumber = symbol - '0';
                    if (currentNumber % 2 == 0)
                    {
                        sumEven += currentNumber;
                    }
                    else
                    {
                        sumOdd += currentNumber;
                    }

                }
            }

            if (sumOdd < sumEven)
            {
                Console.WriteLine("right " + sumEven);
            }
            else if (sumOdd > sumEven)
            {
                Console.WriteLine("left " + sumOdd);
            }
            else
            {
                Console.WriteLine("straight " + sumEven);
            }

        }
    }
}
