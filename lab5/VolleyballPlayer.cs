using System;
using System.Collections.Generic;
using System.Text;

namespace Lab5
{
    class VolleyballPlayer : Sportsman
    {
        public VolleyballPlayer() : base()
        {
            Sport = Sports.VolleyballPlayer;
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
            Console.WriteLine("Sport of {0} is Volleyball", Name);
        }
        public override void PlayerOfTheYearWin()
        {
            base.PlayerOfTheYearWin();
            Console.WriteLine("You won volleyball player of the year award");
        }
    }
}
