using System;

namespace FloatDouble
{
    /// <sumary>
    /// Floating Point Data Types Lecture code
    /// </summary>
    class MainClass
    {
        /// <summary>
        /// Demonstrates floating point data types
        /// </summary>
        /// <param name="args">command-line arguments</param>
        public static void Main(string[] args)
        {
            int score = 1360;
            in totalSecondsPlayed = 10000;

            // calculate and print points per second
            float pointsPerSecond = (float) score / totalSecondsPlayed;
            Console.WriteLine("Points per Second: " + pointsPerSecond);

            Console.WriteLine();
        }
    }
}
