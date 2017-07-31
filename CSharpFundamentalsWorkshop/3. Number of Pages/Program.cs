//solved 80/100

using System;

namespace BooksAndPages
{
    class Program
    {
        static void Main()
        {
            int digits = int.Parse(Console.ReadLine());
            int pages = 0;

            /*
             9 * 1 = 9               | 9
             90 * 2 = 180            | 189
             900 * 3 = 2 700         | 2 889
             9000 * 4 = 36 000       | 38 889
             90000 * 5 = 450 000     | 488 889
             900000 * 6 = 5 400 000  | 5 888 889
             9000000 * 7 = 620 000   | 68 888 889
             */

            if (digits <= 9)
            {
                pages = digits;
            }
            else if (digits <= 99)
            {
                pages = ((digits - 9) / 2) + 9;
            }
            else if (digits <= 999)
            {
                pages = ((digits - 189) / 3) + 99;
            }
            else if (digits <= 9999)
            {
                pages = ((digits - 2889) / 4) + 999;
            }
            else if (digits <= 99999)
            {
                pages = ((digits - 38889) / 5) + 9999;
            }
            else if (digits <= 999999)
            {
                pages = ((digits - 488889) / 6) + 99999;
            }
            else if (digits <= 999999)
            {
                pages = ((digits - 5888889) / 7) + 999999;
            }
            else if (digits <= 999999)
            {
                pages = ((digits - 68888889) / 8) + 9999999;
            }


            Console.WriteLine(pages);

        }
    }
}
