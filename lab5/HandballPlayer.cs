using System;
using System.Collections.Generic;
using System.Text;

namespace Lab5
{
    class HandballPlayer : Sportsman
    {
        public HandballPlayer() : base()
        {
            Sport = Sports.HandballPlayer;
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
            Console.WriteLine("Sport of {0} is Handball", Name);
        }
        public override void PlayerOfTheYearWin()
        {
            base.PlayerOfTheYearWin();
            Console.WriteLine("You won  IHF World Player of the Year");
        }
    }
}
