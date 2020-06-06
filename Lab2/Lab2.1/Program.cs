using System;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            string FullString;
            Console.WriteLine("Enter string:\t");
            FullString = Console.ReadLine();
            string FinalString = string.Join(" ", FullString.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries));
            string[] Words = FinalString.Split(' ');

            for (int i = Words.Length - 1; i >= 0; i--)
            {
                Console.Write(Words[i] + " ");
            }

        }
    }
}