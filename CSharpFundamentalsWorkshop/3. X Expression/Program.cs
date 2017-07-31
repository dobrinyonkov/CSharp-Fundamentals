//solved 100/100

using System;

namespace expression2
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            decimal result = 0;
            decimal resultInBracket = 0;

            char currentoperator = '+';
            char bracketoperator = '+';

            bool inBracket = false;

            foreach (char symbol in text)
            {
                if (symbol == '(')
                {
                    inBracket = true;
                    continue;
                }

                if (symbol == ')')
                {
                    inBracket = false;
                    switch (currentoperator)
                    {
                        case '+': result += resultInBracket; break;
                        case '-': result -= resultInBracket; break;
                        case '/': result /= resultInBracket; break;
                        case '*': result *= resultInBracket; break;
                    }
                    resultInBracket = 0;
                    bracketoperator = '+';
                }

                if (symbol == '+' ||
                    symbol == '-' ||
                    symbol == '/' ||
                    symbol == '*')
                {
                    if (inBracket)
                    {
                        bracketoperator = symbol;
                    }
                    else
                    {
                        currentoperator = symbol;
                    }
                }

                if (char.IsDigit(symbol))
                {
                    int currentnumber = symbol - '0';

                    if (inBracket)
                    {
                        switch (bracketoperator)
                        {
                            case '+': resultInBracket += currentnumber; break;
                            case '-': resultInBracket -= currentnumber; break;
                            case '/': resultInBracket /= currentnumber; break;
                            case '*': resultInBracket *= currentnumber; break;
                        }
                    }

                    else
                    {
                        switch (currentoperator)
                        {
                            case '+': result += currentnumber; break;
                            case '-': result -= currentnumber; break;
                            case '/': result /= currentnumber; break;
                            case '*': result *= currentnumber; break;
                        }
                    }

                }
            }
            Console.WriteLine("{0:F2}", result);
        }
    }
}