//solved 90/100

using System;

class Program
{
    static void Main()
    {
        string text = Console.ReadLine();
        int i = 0;
        int num = 0;
        while (true)
        {

            num = text[i] - '0';
            if (num == 0)
            {
                Console.WriteLine("Too drunk to go on after {0}!", i);
                break;
            }
            else if (num == 46)
            {
                Console.WriteLine("Jump, Jump, DJ Tomekk kommt at {0}!", i);
                break;
            }
            if (num % 2 == 0)
            {
                i += num;
            }
            else if (num % 2 == 1)
            {
                i -= num;
            }

            if (i > text.Length || i < 0)
            {
                Console.WriteLine("Fell off the dancefloor at {0}!", i);
                break;
            }

        }

    }
}
