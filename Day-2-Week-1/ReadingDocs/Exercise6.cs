using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter an angle in degrees: ");
            int angle = int.Parse(Console.ReadLine());
            float cosine = (float)Math.Cos(angle * (float)Math.PI / 180);

            Console.WriteLine("The Cosine of " + angle + " is: " + cosine);
            Console.WriteLine();
        }
    }
}