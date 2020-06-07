using System;
using System.Collections.Generic;
using System.Text;

namespace Lab6
{
    enum Gender
    {
        Male,
        Female,
        Alien
    }
    class Human
    {
        public String Name { get; set; }
        public Gender GenderOfHuman { get; set; }
        public double Weight { get; set; }
        public int Height { get; set; }
        public int Age { get; set; }
        public Human(double PassedWeight, int PassedHeight, int PassedAge, String PassedName, Gender PassedGender)
        {
            Weight = PassedWeight;
            Height = PassedHeight;
            Age = PassedAge;
            Name = PassedName;
            GenderOfHuman = PassedGender;
        }
        public Human()
        {
            double PassedWeight;
            int PassedAge, PassedHeight, Choice;
            Console.WriteLine("Set Name :");
            Name = Console.ReadLine();
            Console.WriteLine("Set Weight :");
            while (!double.TryParse(Console.ReadLine(), out PassedWeight))
            {
                Console.WriteLine("Wrong Input,Try Again");
            }
            Weight = PassedWeight;
            Console.WriteLine("Set Age :");
            while (!int.TryParse(Console.ReadLine(), out PassedAge))
            {
                Console.WriteLine("Wrong Input,Try Again");
            }
            Age = PassedAge;
            Console.WriteLine("Set Height :");
            while (!int.TryParse(Console.ReadLine(), out PassedHeight))
            {
                Console.WriteLine("Wrong Input,Try Again");
            }
            Height = PassedHeight;
            Console.WriteLine("Choose Gender\n1.Male\n2.Female\n3.Not Sure");
            do
            {
                Int32.TryParse(Console.ReadLine(), out Choice);
                switch (Choice)
                {
                    case 1: GenderOfHuman = Gender.Male; break;
                    case 2: GenderOfHuman = Gender.Female; break;
                    case 3: GenderOfHuman = Gender.Alien; break;
                    default: Console.WriteLine("\nWrong input\n"); break;
                }
            }
            while (Choice < 1 || Choice > 3);
        }
        public virtual void PrintInfo()
        {
            Console.WriteLine("Weight of {4} : {0}\nHeight of {4} : {1}\nAge of {4} : {2}\nGender of {4} : {3}", Weight, Height, Age, GenderOfHuman, Name);
        }
        public virtual void GetOlder()
        {
            if (Age > 0 && Age < 15)
            {
                Height += 10;
                Weight += 5;
                Age++;
                Console.WriteLine("Happy Bitrhday To You!!!");
            }
            else if (Age >= 15 && Age <= 20)
            {
                Height += 5;
                Age++;
                Console.WriteLine("You're an adult now ");
            }
            else if (Age > 20 && Age <= 30)
            {
                Age++;
                Console.WriteLine("Hpy biorthddday!!!Fil the glasees faster");
            }
            else if (Age > 30 && Age <= 50)
            {
                Weight += 2;
                Age++;
                Console.WriteLine("Ok,one year more");
            }
            else if (Age > 50 && Age <= 70)
            {
                Weight += 2;
                Age++;
                Console.WriteLine("Not this again");
            }
            else if (Age > 70 && Age <= 120)
            {
                Height -= 5;
                Age++;
                Console.WriteLine("I'm still quite young");
            }
            else
            {
                Console.WriteLine("i think you're dead");
            }

        }
        public void Eat()
        {
            if (GenderOfHuman == Gender.Alien)
            {
                Console.WriteLine("I wouldn't do this if I were you");
            }
            else
            {
                Console.WriteLine("MMM,Nice");
            }

        }
    }
}
