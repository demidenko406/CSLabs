using System;
using System.Collections.Generic;
using System.Text;

namespace Lab8
{
    class HandballPlayer : Sportsman, ISportsman, ITraining
    {
        public int Matches { get; set; }
        public int Goals { get; set; }
        public HandballPlayer() : base()
        {
            Sport = Sports.HandballPlayer;
            Matches = 0;
            Goals = 0;
        }
        public override void BecomeTheMVP()
        {
            base.BecomeTheMVP();
            Console.WriteLine("Wow,you scored 20?More??");
        }
        public override void EndCareer()
        {
            base.EndCareer();
            Console.WriteLine("When this player was playing it looke like ther was 8 players int the team.Goodbye");
        }

        public override void PrintInfo()
        {
            base.PrintInfo();
            Console.WriteLine("Sport of {0} is Handball\nMatches of {0} is {1}\nGoals of {0} is {2}", Name, Matches, Goals);
        }
        public override void PlayerOfTheYearWin()
        {
            base.PlayerOfTheYearWin();
            Console.WriteLine("You won  IHF World Player of the Year");
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
            strenght += 20;
            Console.WriteLine("Going to GYM");
        }
    }
}
