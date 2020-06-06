using System;
using System.Globalization;
using System.Threading;

namespace Lab2._2
{
    class Program
    {
        static void Main(string[] args)
        {
            char Language;
            do
            {
                Console.Clear();
                Console.WriteLine(
                    "Сhoose language:\n1.Russian\n2.French\n3.German.\n4.Exit.");
                Language = Convert.ToChar(Console.ReadLine());
                DateTime Months = new DateTime();
                switch (Language)
                {
                    case '1':
                    {
                        Thread.CurrentThread.CurrentCulture = new CultureInfo(0x0419);
                        break;
                    }

                    case '2':
                    {
                        Thread.CurrentThread.CurrentCulture = new CultureInfo(0x040C);
                        break;
                    }

                    case '3':
                    {
                        Thread.CurrentThread.CurrentCulture = new CultureInfo(0x0407);
                        break;
                    }
                    case '4':
                        break;
                    default:
                    {
                        Console.WriteLine("You must have entered something wrong.\n");
                        break;
                    }
                }
                if (Language == '4')
                    break;
                for (int i = 0; i < 12; i++)
                {
                    string Month = Months.ToString("M");
                    Console.WriteLine(Month);
                    Months = Months.AddMonths(1);
                }
                Console.ReadKey();
            } while (true);
            Console.WriteLine("):");
        }
    }
}