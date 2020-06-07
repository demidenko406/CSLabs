using System;
using System.Collections.Generic;
using System.Text;

namespace Lab5
{
    class Footballer : Sportsman
    {
        public Footballer() : base()
        {
            Sport = Sports.Footballer;
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
            Console.WriteLine("Sport of {0} is Football", Name);
        }
        public override void PlayerOfTheYearWin()
        {
            base.PlayerOfTheYearWin();
            Console.WriteLine("You won  Baloon D'or");
        }
    }
}