using System;
using System.Collections.Generic;
using System.Text;

namespace Lab8
{
    class VolleyballPlayer : Sportsman, ISportsman, ITraining
    {
        public int Matches { get; set; }
        public int Goals { get; set; }
        public VolleyballPlayer() : base()
        {
            Sport = Sports.VolleyballPlayer;
            Matches = 0;
            Goals = 0;
        }
        public override void BecomeTheMVP()
        {
            base.BecomeTheMVP();
            Console.WriteLine("This blocks were awesome");
        }
        public override void EndCareer()
        {
            base.EndCareer();
            Console.WriteLine("It was such a great career");
        }

        public override void PrintInfo()
        {
            base.PrintInfo();
            Console.WriteLine("Sport of {0} is Volleyball\nMatches of {0} is {1}\nGoals of {0} is {2}", Name, Matches, Goals);
        }
        public override void PlayerOfTheYearWin()
        {
            base.PlayerOfTheYearWin();
            Console.WriteLine("You won volleyball player of the year award");
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
            Console.WriteLine("O,there's no talk bout points");
        }
        public void Train()
        {
            strenght += 10;
            Console.WriteLine("Playing Beach Volleyball");
        }
    }
}