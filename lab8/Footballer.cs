using System;
using System.Collections.Generic;
using System.Text;

namespace Lab8
{
    class Footballer : Sportsman, ISportsman, ITraining
    {
        public int Matches { get; set; }
        public int Goals { get; set; }
        public Footballer() : base()
        {
            Sport = Sports.Footballer;
            Matches = 0;
            Goals = 0;
        }
        public override void BecomeTheMVP()
        {
            base.BecomeTheMVP();
            Console.WriteLine("You played like the Messi this time");
        }
        public override void EndCareer()
        {
            Console.WriteLine("The Greatest player in the history of {0} ended his career", Club);
            base.EndCareer();
        }
        public override void PrintInfo()
        {
            base.PrintInfo();
            Console.WriteLine("Sport of {0} is Football\nMatches of {0} is {1}\nGoals of {0} is {2}", Name, Matches, Goals);
        }
        public override void PlayerOfTheYearWin()
        {
            base.PlayerOfTheYearWin();
            Console.WriteLine("You won  Baloon D'or");
        }
        public void PlayMatch()
        {
            Matches++;
            int GoalsInMatch;
            Console.WriteLine("How many you scored:");
            while (!Int32.TryParse(Console.ReadLine(), out GoalsInMatch))
            {
                Console.WriteLine("Wrong Input,Try Again");
            }
            Goals += GoalsInMatch;
            if (GoalsInMatch < 1)
            {
                Console.WriteLine("Are you a keeper");
            }
            else if (GoalsInMatch >= 1 && GoalsInMatch < 3)
            {
                Console.WriteLine("You did well");
            }
            else if (GoalsInMatch >= 3)
            {
                Console.WriteLine("You're a new candidat for a Baloon D'or");
            }
        }
        public void Train()
        {
            strenght += 0;
            Console.WriteLine("Bying another car");
        }
    }
}