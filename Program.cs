namespace SportsEvent
{
    internal class Program
    {

        public class SportsEvent
        {
            private double[] scores = new double[8];


            /// <summary>
            /// This method prompts the user to enter in 8 scores and stores
            /// them in the array scores.
            /// </summary>
            public void ReadScores()
            {
                // TODO : Implement reading 8 scores from the user
                Console.WriteLine("Enter Eight Contestant Scores:");
                for (int i = 0; i < 8; i++)
                {
                    Console.Write($"Judge {i + 1} --> ");
                    double score = double.Parse(Console.ReadLine());
                    scores[i] = score;
                }
            }


            /// <summary>
            /// Determines which score in scores is the lowest
            /// </summary>
            /// <returns>The lowest score in scores</returns>
            public double Lowest()
            {
                return scores.Min();
            }


            /// <summary>
            /// Determines which score in scores is the highest
            /// </summary>
            /// <returns>The highest score in scores</returns>
            public double Highest()
            {
                // TODO : Determine the highest score
                return 0;
            }


            /// <summary>
            /// Calculates the average of scores with the lowest and highest scores
            /// thrown out.
            /// </summary>
            /// <returns>The average</returns>
            public double Average()
            {
                return scores.Average(); 
            }


            /// <summary>
            /// This method prints a summary report which includes the original list of
            /// scores, the average of the scores, the lowest score, and the highest score.
            /// </summary>
            public void PrintSummary()
            {
                // TODO : Print summary report
                Console.WriteLine("                  Summary Report                 ");
                Console.WriteLine("-------------------------------------------------");
                Console.Write($"Scores = ");
                foreach (var score in scores)
                {
                    Console.Write(score + " ");
                }
                Console.WriteLine($"\nLowest Score = {Lowest()}");
                Console.WriteLine($"Highest Score = {Highest()}");
                Console.WriteLine($"Average Score = {Average()}");
            }
        }
        /// <summary>
        /// Program entry point.
        /// </summary>
        /// <param name="args">Command-line arguments</param>
        public static void Main(string[] args)
        {
            SportsEvent app = new SportsEvent();
            app.ReadScores();
            app.PrintSummary();
        }

    }
}
