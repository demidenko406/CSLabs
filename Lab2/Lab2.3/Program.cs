using System;

namespace lab2._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Eneter your string:\t");
            string InputString = Console.ReadLine();
            string[] Words = InputString.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int count = 0;
            foreach (string Word in Words)
            {
                if (Word[Word.Length - 1] == ',' || Word[Word.Length - 1] == '.')
                {
                    char pad = Word[Word.Length - 1];
                    Words[count] = Word.PadLeft(Word.Length + 1, pad);
                    count++;
                }
                else
                {
                    count++;
                }
            }
            string FinalString = String.Join(" ", Words);
            Console.WriteLine(FinalString);
            Console.ReadLine();
        }
    }
}