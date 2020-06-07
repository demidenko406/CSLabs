using System;
using System.Collections.Generic;
using System.Text;

namespace Lab8
{
    class Match
    {
        public int Goals1, Goals2;
        public delegate void MatchHandler(string message);
        public event MatchHandler Notify;
        public delegate void ShowTable(int x, int y);
         public ShowTable showTable = (x, y) =>Console.WriteLine($"{x}:{y}");
        public Match()
        {
            Goals1 = 0;
            Goals2 = 0;
        }
        public void Score1(int score)
        {
            Goals1 += score;
            Notify?.Invoke($"Your team scored: {score}");
            if (Goals1 > Goals2)
            {
                Notify?.Invoke("Your team is winning now");   
            }
            else
            {
                Notify?.Invoke("Score more"); ;
            }
        }
        public void Score2(int score)
        {
            Goals2 += score;
            Notify?.Invoke($"Your team scored: {score}");
            if (Goals2 > Goals1)
            {
                Notify?.Invoke("Your team is losing now");  
            }
            else
            {
                Notify?.Invoke("It's ok"); ;
            }
        }
        public void FinishMatch()
        {
            if (Goals2 > Goals1)
            {
                Notify?.Invoke("You lost");
            }
            else if (Goals2 < Goals1)
            {
                Notify?.Invoke("It's ok");
            }
            else {
                Notify?.Invoke("Draw");
            }
        }
    }
}

