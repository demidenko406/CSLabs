using System;
using static System.Console;

static class Program
{
    static RatNumber Choose(ref RatNumber num1, ref RatNumber num2)
    {
        WriteLine("Press:\n 1 - With firs.\n 2 - With second.");
        switch (ReadKey(true).Key)
        {
            case ConsoleKey.D1: return num1;
            case ConsoleKey.D2: return num2;
        }
        return null;
    }

    static void Change(ref RatNumber num1, ref RatNumber num2, RatNumber num)
    {
        WriteLine("Press:\n 1 - Add to first\n 2 - Ad to second.\n 3 - Output");
        switch (ReadKey(true).Key)
        {
            case ConsoleKey.D1: num1 = num; break;
            case ConsoleKey.D2: num2 = num; break;
            case ConsoleKey.D3: WriteLine("Value equals {0}", num.Delenie); break;
        }
    }

    static void Menu()
    {
        WriteLine(" 0 - Exit\n 1 - numerator and denominator output\n 2 - String output\n 3 - Output\n 4 - subtraction \n 5 - Work wit hwo elements");
    }

    static void Main()
    {
        RatNumber num1 = new RatNumber(1, 2);
        RatNumber num2 = new RatNumber(2, 4);
        RatNumber nums;
        while (true)
        {
            Clear();
            Menu();
            switch (ReadKey(true).Key)
            {
                case ConsoleKey.D0: Clear(); return;

                case ConsoleKey.D1: Clear(); Choose(ref num1, ref num2)?.WriteNumDen(); WriteLine("Press any key..."); ReadKey(); break;

                case ConsoleKey.D2:
                    Clear();
                    if ((nums = Choose(ref num1, ref num2)) == num1 && num1 != null)
                        RatNumber.WriteNum(ref num1);
                    else if (nums == num2 && num2 != null)
                        RatNumber.WriteNum(ref num2);
                    WriteLine("Press any key..."); ReadKey(); break;

                case ConsoleKey.D3: Clear(); Choose(ref num1, ref num2)?.NumOut(); WriteLine("Press any key..."); ReadKey(); break;

                case ConsoleKey.D4:
                    Clear(); WriteLine("Difference is  {0:f}", IComparison.Comparison(num1, num2));
                    WriteLine("Press any key..."); ReadKey(); break;

                case ConsoleKey.D5:
                    Clear(); WriteLine("Classes equals {0}", IComparison.Equals(num1, num2));
                    WriteLine("Press any key..."); ReadKey(); break;

                case ConsoleKey.D6:
                    Clear();
                    WriteLine(" 1 - Sum\n 2 - Difference\n 3 - Multiply\n 4 - Divide\n 5 - Compare on >\n" +
                        " 6 - Compare on  <\n 7 - Compare on >=\n 8 - Compare on <=\n");
                    switch (ReadKey(true).Key)
                    {
                        case ConsoleKey.D1: Change(ref num1, ref num2, num1 + num2); break;
                        case ConsoleKey.D2: Change(ref num1, ref num2, num1 - num2); break;
                        case ConsoleKey.D3: Change(ref num1, ref num2, num1 * num2); break;
                        case ConsoleKey.D4: Change(ref num1, ref num2, num1 / num2); break;
                        case ConsoleKey.D5: WriteLine("! element > secont element,  {0}", num1 > num2); break;
                        case ConsoleKey.D6: WriteLine("! element > secont element,  {0}", num1 < num2); break;
                        case ConsoleKey.D7: WriteLine("! element > secont element,  {0}", num1 >= num2); break;
                        case ConsoleKey.D8: WriteLine("! element > secont element,  {0}", num1 <= num2); break;
                    }
                    WriteLine("Press any key...");
                    ReadKey();
                    break;
            }
        }
    }
}