using System;
using System.Collections.Generic;
using System.Text;

namespace Lab8
{
    class BasketballPlayer : Sportsman, ISportsman, ITraining
    {
        public int Matches { get; set; }
        public int Goals { get; set; }
        public BasketballPlayer() : base()
        {
            Sport = Sports.BasketballPlayer;
            Matches = 0;
            Goals = 0;
        }
        public override void BecomeTheMVP()
        {
            base.BecomeTheMVP();
            Console.WriteLine("Triple Double Triple");
        }
        public override void EndCareer()
        {
            base.EndCareer();
            Console.WriteLine("Now you're in  Naismith Memorial Basketball Hall of Fame");
        }

        public override void PrintInfo()
        {
            base.PrintInfo();
            Console.WriteLine("Sport of {0} is Basketball\nMatches of {0} is {1}\nGoals of {0} is {2}", Name, Matches, Goals);
        }
        public override void PlayerOfTheYearWin()
        {
            base.PlayerOfTheYearWin();
            Console.WriteLine("You won NBA Most Valuable Player");
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
            if (GoalsInMatch < 15)
            {
                Console.WriteLine("Oww,Not so Great");
            }
            else if (GoalsInMatch >= 15 && GoalsInMatch < 40)
            {
                Console.WriteLine("You did well");
            }
            else if (GoalsInMatch >= 40)
            {
                Console.WriteLine("Wow,Is it Jordan????");
            }
        }
        public void Train()
        {
            strenght += 5;
            Console.WriteLine("Goes to Fashion Week");
        }
    }
}
