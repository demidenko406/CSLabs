using System;
using System.Collections.Generic;
using System.Text;

namespace Lab5
{
    class BasketballPlayer : Sportsman
    {
        public BasketballPlayer() : base()
        {
            Sport = Sports.BasketballPlayer;
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
            Console.WriteLine("Sport of {0} is Basketball", Name);
        }
        public override void PlayerOfTheYearWin()
        {
            base.PlayerOfTheYearWin();
            Console.WriteLine("You won NBA Most Valuable Player");
        }
    }
}
