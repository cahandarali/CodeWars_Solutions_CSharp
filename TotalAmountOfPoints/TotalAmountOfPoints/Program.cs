using System.Text;

namespace TotalAmountOfPoints
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] a = { "1:0", "2:0", "3:0", "4:0", "2:1", "3:1", "4:1", "3:2", "4:2", "4:3" };
            Console.WriteLine(TotalPoints(a));
        }
        public static int TotalPoints(string[] games)
        {
            int total = 0;
            foreach (string game in games)
            {
                string[] score = game.Split(':');
                int OurGoals = int.Parse(score[0]);
                int EnemyGoals = int.Parse(score[1]);

                int point = 0;
                if(OurGoals>EnemyGoals)
                {
                    point = 3;
                }
                else if(OurGoals==EnemyGoals)
                {
                    point = 1;
                }

                total += point;
            }
            return total;
        }
    }
}



//{ "1:0", "2:0", "3:0", "4:0", "2:1", "3:1", "4:1", "3:2", "4:2", "4:3" }