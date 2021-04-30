using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise4
{
    /// <summary>
    /// In the Main method, calculate the altitude of two different locations and display the difference.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter first altitude: ");
            int firstAltitude = int.Parse(Console.ReadLine());
            Console.Write("Enter second altitude: ");
            int secondAltitude = int.Parse(Console.ReadLine());


            Console.WriteLine("The Change in altitude is: " + (firstAltitude - secondAltitude));
            Console.WriteLine();
        }
    }
}