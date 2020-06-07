using System;
using System.Collections.Generic;

namespace Lab6
{
    class Program
    {
        static void Main(string[] args)
        {
            int Number, NumberOfSportsman = 0;
            List<Sportsman> sportsmen = new List<Sportsman>();
            do
            {
                MainMenu();
                while (!int.TryParse(Console.ReadLine(), out Number) && Number < 0 && Number >= 12)
                {
                    Console.WriteLine("Wrong Input,Try Again");
                }
                switch (Number)
                {
                    case 1:
                        AddSportsman(sportsmen);
                        break;
                    case 2:
                        NumberOfSportsman = ChooseOnePlayer(sportsmen);
                        break;
                    case 3:
                        sportsmen[NumberOfSportsman].Eat();
                        Console.ReadKey();
                        break;
                    case 4:
                        sportsmen[NumberOfSportsman].GetOlder();
                        Console.ReadKey();
                        break;
                    case 5:
                        sportsmen[NumberOfSportsman].PrintInfo();
                        Console.ReadKey();
                        break;
                    case 6:
                        sportsmen[NumberOfSportsman].Transfer();
                        Console.ReadKey();
                        break;
                    case 7:
                        sportsmen[NumberOfSportsman].EndCareer();
                        Console.ReadKey();
                        break;
                    case 8:
                        sportsmen[NumberOfSportsman].PlayerOfTheYearWin();
                        Console.ReadKey();
                        break;
                    case 9:
                        sportsmen[NumberOfSportsman].BecomeTheMVP();
                        Console.ReadKey();
                        break;
                    case 10:
                        ((ISportsman)sportsmen[NumberOfSportsman]).PlayMatch();
                        Console.ReadKey();
                        break;
                    case 11:
                        ((ITraining)sportsmen[NumberOfSportsman]).Train();
                        Console.ReadKey();
                        break;
                    default:
                        break;
                }
            } while (Number > 0 && Number < 12);
        }
        private static void MainMenu()
        {
            Console.Clear();
            Console.WriteLine("Choose an option:");
            Console.WriteLine("1) Create Sportsman");
            Console.WriteLine("2) Choose Sportsman from Group");
            Console.WriteLine("3) Eat");
            Console.WriteLine("4) Get Older");
            Console.WriteLine("5) Print Info");
            Console.WriteLine("6) Transfer Proposal");
            Console.WriteLine("7) End Career");
            Console.WriteLine("8) Player of the Year");
            Console.WriteLine("9) MVP");
            Console.WriteLine("10) PlayMatch");
            Console.WriteLine("11) Train");
            Console.WriteLine("12) Exit");
        }
        private static void AddSportsman(List<Sportsman> Sportsmen)
        {
            Sportsmen.Add(ChooseSport());

        }
        private static int ChooseOnePlayer(List<Sportsman> Sportsmen)
        {
            int Choose;
            for (int i = 0; i < Sportsmen.Count; i++)
            {
                Console.WriteLine((i + 1) + " - " + Sportsmen[i].Name);
            }
            while (!int.TryParse(Console.ReadLine(), out Choose))
            {
                Console.WriteLine("Wrong Input,Try Again");
            }
            return Choose - 1;
        }
        private static Sportsman ChooseSport()
        {
            int Choice;
            Console.WriteLine("\nChouse your sport 1.Football 2.Basketball 3.Volleyball 4.Handball\n\n");
            while (!int.TryParse(Console.ReadLine(), out Choice) && Choice < 0 && Choice >= 5)
            {
                Console.WriteLine("Wrong Input,Try Again");
            }
            switch (Choice)
            {
                case 1:
                    {
                        return new Footballer() as Sportsman;
                    }
                case 2:
                    {
                        return new BasketballPlayer() as Sportsman;
                    }
                case 3:
                    {
                        return new VolleyballPlayer() as Sportsman;

                    }
                case 4:
                    {
                        return new HandballPlayer() as Sportsman;

                    }
                default:
                    {
                        throw new Exception("Wrong");
                    }
            }
        }
    }
}

