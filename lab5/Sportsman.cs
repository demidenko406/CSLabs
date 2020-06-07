using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.ComTypes;
using System.Text;

namespace Lab5
{
    public enum Sports
    {
        Footballer,
        VolleyballPlayer,
        BasketballPlayer,
        HandballPlayer
    }
    class Sportsman : Human
    {
        
        protected int strenght;
        public int Strength {
            get
            {
                return strenght;
            }
            set
            {
                while (value < 0) { 
                Console.WriteLine("Should be positive");
                }
                strenght = value;
            }
        }
        protected string club;
        public string Club
        {
            get
            {
                return club;
            }
            set
            {
                club = value;
            }
        }
        public bool Injury = false;
        protected int transferPrice;
        public int TransferPrice
        {
            get
            {
                return transferPrice;
            }
            set
            {
                while (value < 0)
                {
                    Console.WriteLine("Should be positive");
                }
                transferPrice = value;
            }
        }
        protected int salary;
        public int Salary
        {
            get
            {
                return salary;
            }
            set
            {
                while (value < 0)
                {
                    Console.WriteLine("Should be positive");
                }
                salary = value;
            }
        }
        protected Sports sport;
        public Sports Sport 
        {
            get
            {
                return sport;
            }
            set
            {
                sport = value;
            }
        }
        public Sportsman() : base () {
            int PassedSalary, PassedTransferPrice, PassedStrength,Choice;
            Console.WriteLine("Set Salary :");
            while (!Int32.TryParse(Console.ReadLine(), out PassedSalary))
            {
                Console.WriteLine("Wrong Input,Try Again");
            }
            Salary = PassedSalary;
            Console.WriteLine("Set Club :");
            Club = Console.ReadLine();
            Console.WriteLine("Set Strength :");
            while (!Int32.TryParse(Console.ReadLine(), out PassedStrength))
            {
                Console.WriteLine("Wrong Input,Try Again");
            }
            Strength = PassedStrength;
            Console.WriteLine("Set Transfer Price :");
            while (!Int32.TryParse(Console.ReadLine(), out PassedTransferPrice))
            {
                Console.WriteLine("Wrong Input,Try Again");
            }
            TransferPrice = PassedTransferPrice;
            Console.WriteLine("Is player Injured : 1.Yes 2.No");
            do
            {
                Int32.TryParse(Console.ReadLine(), out Choice);
                switch (Choice)
                {
                    case 1: Injury = true; break;
                    case 2: Injury = false; break;
                    default: Console.WriteLine("\nWrong input\n"); break;
                }
            }
            while (Choice < 1 || Choice > 2);

        }
        public override void PrintInfo()
        {
            base.PrintInfo();
            Console.WriteLine("Salary of {4} : {0}\nTransfer price of {4} : {1}\nInjury of {4} : {2}\nStrength of {4} : {3}\nClub of {4} : {5}", Salary, TransferPrice, Injury,Strength, Name,Club);
        }
        public override void GetOlder()
        {
            if (Age > 0 && Age < 15)
            {
                Height += 10;
                Weight += 5;
                Strength += 15;
                Age++;
                Console.WriteLine("Happy Bitrhday To You!!!");
            }
            else if (Age >= 15 && Age <= 20)
            {
                Height += 5;
                Age++;
                Strength += 10;
                TransferPrice += 10000;
                Salary += 5000;
                Console.WriteLine("You're an adult now ");
            }
            else if (Age > 20 && Age <= 30)
            {
                Age++;
                Strength += 3;
                TransferPrice += 1000;
                Salary += 500;
                Console.WriteLine("Hpy biorthddday!!!Fil the glasees faster");
            }
            else if (Age > 30 && Age <= 50)
            {
                Weight += 2;
                Strength -= 10;
                TransferPrice -= 10000;
                Salary -= 5000;
                Age++;
                Console.WriteLine("Ok,one year more");
            }
            else if (Age > 50 && Age <= 70)
            {
                Weight += 2;
                Age++;
                Strength -= 20;
                TransferPrice -= 30000;
                Salary -= 15000;
                Console.WriteLine("Not this again");
            }
            else if (Age > 70 && Age <= 120)
            {
                Strength -= 50;
                Height -= 5;
                Age++;
                Console.WriteLine("I'm still quite young");
            }
            else
            {
                Console.WriteLine("i think you're dead");
            }
        }
        public void Transfer() {
            int Transfer,NewSalary;
            string NewClub;
            Console.WriteLine("Enter New Salary:");
            while (!Int32.TryParse(Console.ReadLine(), out NewSalary))
            {
                Console.WriteLine("Wrong Input,Try Again");
            }
            Console.WriteLine("Enter your possible pay:");
            while (!Int32.TryParse(Console.ReadLine(), out Transfer))
            {
                Console.WriteLine("Wrong Input,Try Again");
            }
            Console.WriteLine("Enter club name:");
            NewClub = Console.ReadLine();
            if (Transfer > TransferPrice && Salary < NewSalary) {
                Club = NewClub;
                Salary = NewSalary;
                Console.WriteLine("Your new club is {0}", Club);
            } 
        }
        public virtual void BecomeTheMVP() {
            Console.WriteLine("Great perfomance");
            TransferPrice += 1000;
        }
        public virtual void EndCareer()
        {
            Console.WriteLine("It was nice journey");
            TransferPrice =0;
            Salary = 0;
            Club = "No Club";
        }
        public virtual void PlayerOfTheYearWin() {
            Console.WriteLine("Congratulations");
            TransferPrice += 10000;
            Salary += 1110;
        }

    }
}
