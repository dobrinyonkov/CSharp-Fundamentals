//solved 100/100

using System;
using System.Globalization;

namespace Problem_1___Next_Date
{
    class Program
    {
        static void Main(string[] args)
        {
            string day = Console.ReadLine();
            string month = Console.ReadLine();
            string year = Console.ReadLine();

            string date = day + "/" + month + "/" + year;

            DateTime dt = DateTime.ParseExact(date, "d/M/yyyy", CultureInfo.InvariantCulture);

            dt = dt.AddDays(1);
            Console.WriteLine(dt.ToString("d.M.yyyy"));

        }
    }
}