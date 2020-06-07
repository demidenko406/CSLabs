using System;
using static System.Console;
using System.Runtime.InteropServices;

namespace Lab4._2
{
    class Program
    {
        [DllImport(@"D:\Study\Labs\CS\Lab4.2\Debug\MyLib.dll")]
        public static extern int Add(int a, int b);
        [DllImport(@"D:\Study\Labs\CS\Lab4.2\Debug\MyLib.dll")]
        public static extern int Sub(int a, int b);
        [DllImport(@"D:\Study\Labs\CS\Lab4.2\Debug\MyLib.dll")]
        public static extern int Mult(int a, int b);
        [DllImport(@"D:\Study\Labs\CS\Lab4.2\Debug\MyLib.dll")]
        public static extern int Div(int a, int b);
        [DllImport(@"D:\Study\Labs\CS\Lab4.2\Debug\MyLib.dll")]
        public static extern int Power(int a, int b);
        static void Main()
        {
            WriteLine("Enter 2 numbers");
            int a = int.Parse(ReadLine()), b = int.Parse(ReadLine());
            Console.WriteLine(" Sum = {0}\n Minus = {1}\n Multiply = {2}\n Dividinf = {3}\n a^b = {4}", Add(a, b), Sub(a, b), Mult(a, b), Div(a, b), Power(a, b));
            ReadKey();
        }
    }
}