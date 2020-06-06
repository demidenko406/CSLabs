using System;
using System.Collections.Generic;

namespace Lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            int Number, NumberOfHuman = 0;
            List <Human> People = new List <Human>();
            Human NewHuman = new Human();
            People.Add(NewHuman);
            do
            {
                MainMenu();
                while (!int.TryParse(Console.ReadLine(), out Number) && Number < 0 && Number >= 6)
                {
                    Console.WriteLine("Wrong Input,Try Again");
                }
                switch (Number)
                {
                    case 1:
                        AddHuman(People);
                        break;
                    case 2:
                        NumberOfHuman = ChooseOneHuman(People);
                        break;
                    case 3:
                        People[NumberOfHuman].Eat();
                        Console.ReadKey();
                        break;
                    case 4:
                        People[NumberOfHuman].GetOlder();
                        Console.ReadKey();
                        break;
                    case 5:
                        People[NumberOfHuman].PrintInfo();
                        Console.ReadKey();
                        break;
                    default:
                        break;
                }
            } while (Number > 0 && Number < 6);
        }
        private static void MainMenu()
        {
            Console.Clear();
            Console.WriteLine("Choose an option:");
            Console.WriteLine("1) Create Human");
            Console.WriteLine("2) Choose Human from Group");
            Console.WriteLine("3) Eat");
            Console.WriteLine("4) Get Older");
            Console.WriteLine("5) Print Info");
            Console.WriteLine("6) Exit");
            Console.Write("\r\nSelect an option: ");
        }
        private static void AddHuman(List<Human> Persons)
        {
            Human Person = new Human();
            Persons.Add(Person);

        }
        private static int ChooseOneHuman(List<Human> Persons)
        {
            int Choose;
            for (int i = 0; i < Persons.Count; i++)
            {
                Console.WriteLine((i + 1) + " - " + Persons[i].Name);
            }
            while (!int.TryParse(Console.ReadLine(), out Choose))
            {
                Console.WriteLine("Wrong Input,Try Again");
            }
            return Choose - 1;
        }
    }
}
