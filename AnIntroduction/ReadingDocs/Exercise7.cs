using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise7WithC
{
    class Program
    {
        static void Main(string[] args)
        {
            // Int variables
            int fah;
            int cel;
            int celFah;

            Console.Write("Enter a temperature in Fahrenheit: ");
            fah = int.Parse(Console.ReadLine());
            
            cel = (fah - 32) / 9 * 5;
            Console.WriteLine("Your int temperature in Celcius is: " + cel);

            celFah = (cel * 9) / 5 + 32;
            Console.WriteLine("Your Int Calculated Fahrenheit is: " + celFah);
            Console.WriteLine();
            Console.WriteLine();



            // Float variables
            float floatFah;
            float floatCel;
            float floatCelFah;

            Console.Write("Enter a temperature in Fahrenheit: ");
            floatFah = float.Parse(Console.ReadLine());
            
            floatCel = (floatFah - 32) / 9 * 5;
            Console.WriteLine("Your float temperature in Celcius is: " + floatCel);
            
            floatCelFah = (floatCel * 9) / 5 + 32;
            Console.WriteLine("Your Float Calculated Fahrenheit is: " + floatCelFah);
            Console.WriteLine();
            Console.WriteLine();



            // double variables        
            double doubleFah;
            double doubleCel;
            double doubleCelFah;
            
            Console.Write("Enter a temperature in Fahrenheit: ");
            doubleFah = double.Parse(Console.ReadLine());

            doubleCel = (doubleFah - 32) / 9 * 5;
            Console.WriteLine("Your double temperature in Celsius is: " + doubleCel);

            doubleCelFah = (doubleCel * 9) / 5 + 32;
            Console.WriteLine("Your Double Calculated Fahrenheit is: " + doubleCelFah);
        }
    }
}