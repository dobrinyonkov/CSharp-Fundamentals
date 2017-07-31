//solved 100/100

using System;

namespace _2.Drunken_Numbers
{
    class Program
    {
        static void Main()
        {
            int rounds = int.Parse(Console.ReadLine());

            int mitkoBeers = 0;
            int vladkoBeers = 0;

            for (int i = 0; i < rounds; i++)
            {
                int number = int.Parse(Console.ReadLine());

                if (number < 0)
                {
                    number *= -1;
                }

                int digits = 0;
                int num = number;
                while (num != 0)
                {
                    num /= 10;
                    digits++;
                }

                for (int right = 0; right < digits / 2; right++)
                {
                    // vladkobeers
                    int currentNumber = number % 10;
                    number /= 10;
                    vladkoBeers += currentNumber;

                }

                if (digits % 2 == 1)
                {
                    // check for middle number
                    int middleNumber = number % 10;
                    number /= 10;
                    vladkoBeers += middleNumber;
                    mitkoBeers += middleNumber;
                }

                for (int left = 0; left < digits / 2; left++)
                {
                    // mitkobeers
                    int currentNumber = number % 10;
                    number /= 10;
                    mitkoBeers += currentNumber;
                }

            }
            if (mitkoBeers > vladkoBeers)
            {
                mitkoBeers -= vladkoBeers;
                Console.WriteLine("M {0}", mitkoBeers);
            }
            else if (vladkoBeers > mitkoBeers)
            {
                vladkoBeers -= mitkoBeers;
                Console.WriteLine("V {0}", vladkoBeers);
            }
            else
            {
                vladkoBeers += mitkoBeers;
                Console.WriteLine("No {0}", vladkoBeers);
            }

            //     for (int i = 0; i < rounds; i++)
            //     {
            //         int number = int.Parse(Console.ReadLine());
            //
            //         if (number < 0)
            //         {
            //             number *= -1;
            //         }
            //
            //         int digits = 0;
            //         int num = number;
            //         while (number != 0)
            //         {
            //             num /= 10;
            //             digits++;
            //         }
            //
            //         for (int right = 0; right < digits / 2; right++)
            //         {
            //             int currentDigit = number % 10;
            //             number /= 10;
            //             vladkoBeers += currentDigit;
            //        }
            //
            //         if (digits % 2 == 1)
            //         {
            //             int middleDigit = number % 10;
            //             vladkoBeers += middleDigit;
            //             mitkoBeers += middleDigit;
            //             number /= 10;
            //         }
            //
            //         for (int left = 0; left < digits / 2; left++)
            //         {
            //             int currentDigit = number % 10;
            //             number /= 10;
            //             mitkoBeers += currentDigit;
            //         }
            //     }
            //
            //     if (mitkoBeers > vladkoBeers)
            //     {
            //         mitkoBeers -= vladkoBeers;
            //         Console.WriteLine("M {0}", mitkoBeers);
            //     }
            //     else if (mitkoBeers < vladkoBeers)
            //     {
            //         vladkoBeers -= mitkoBeers;
            //         Console.WriteLine("V {0}", vladkoBeers);
            //     }
            //     else
            //     {
            //         vladkoBeers += mitkoBeers;
            //         Console.WriteLine("No {0}", vladkoBeers);
            //     }
        }
    }
}
