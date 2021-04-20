using System;

namespace ReadingDoc
{
    /// <summary>
    /// Reading Documentation Lecture code
    /// </summary>
    class MainClass
    {
        /// <summary>
        /// Demonstrates reading documentation
        /// </summary>
        /// <param name="args">command-line arguments</param>
        public static void Main(string[] args)
        {
            // calculate and print cosine of 45 degrees
            float cosine = (float)Math.Cos(45 * Math.PI / 180);
            Console.WriteLine("Cosine of 45 degrees: " + cosine);
            
            Console.WriteLine();
        }
    }
}