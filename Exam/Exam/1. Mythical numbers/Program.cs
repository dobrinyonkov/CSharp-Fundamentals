//solved 100/100

using System;

class Program
{
    static void Main()
    {
        int num = int.Parse(Console.ReadLine());

        int lastNum = num % 10;
        num /= 10;
        int middleNum = num % 10;
        num /= 10;
        int firstNum = num;

        if (lastNum == 0)
        {
            int product = middleNum * firstNum;
            Console.WriteLine("{0:f2}", product);
        }
        else if (lastNum > 0 && lastNum <= 5)
        {
            Console.WriteLine("{0:f2}", (middleNum * firstNum) / (double)lastNum);
        }
        else if (lastNum > 5)
        {
            Console.WriteLine("{0:f2}", lastNum * (middleNum + firstNum));
        }
    }
}

