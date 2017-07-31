//solved 100/100

using System;

namespace expression3
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            decimal result = 0;
            decimal resultInBracket = 0;

            char currentOperrator = '+';
            char currentOperratorInBracket = '+';

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
                    switch (currentOperrator)
                    {
                        case '+': result += resultInBracket; break;
                        case '-': result -= resultInBracket; break;
                        case '%': result %= resultInBracket; break;
                        case '*': result *= resultInBracket; break;
                    }
                    resultInBracket = 0;
                    currentOperratorInBracket = '+';
                }

                if (symbol == '+' ||
                    symbol == '-' ||
                    symbol == '%' ||
                    symbol == '*')
                {
                    if (inBracket)
                    {
                        currentOperratorInBracket = symbol;
                    }
                    else
                    {
                        currentOperrator = symbol;
                    }
                }

                if (char.IsDigit(symbol))
                {
                    int currentNumber = symbol - '0';
                    if (inBracket)
                    {
                        switch (currentOperratorInBracket)
                        {
                            case '+': resultInBracket += currentNumber; break;
                            case '-': resultInBracket -= currentNumber; break;
                            case '%': resultInBracket %= currentNumber; break;
                            case '*': resultInBracket *= currentNumber; break;
                        }
                    }
                    else
                    {
                        switch (currentOperrator)
                        {
                            case '+': result += currentNumber; break;
                            case '-': result -= currentNumber; break;
                            case '%': result %= currentNumber; break;
                            case '*': result *= currentNumber; break;
                        }
                    }
                }
            }
            Console.WriteLine("{0:F3}", result);
        }
    }
}
