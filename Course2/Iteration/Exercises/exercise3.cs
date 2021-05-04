using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise3
{
    class Program
    {
        static void Main(String[] args)
        {
            List<int> nums = new List<int>();
            
            // populate nums list
            for (int i = 0; i < 11; i++)
            {
                nums.Add(i);
            }
            
            // print nums list
            for (int i = 0; i < nums.Count; i++)
            {
                Console.WriteLine(nums[i]);
            }
            Console.WriteLine();
            
            // remove even numbers
            for (int i = nums.Count - 1; i >= 0; i--)
            {
                if (nums[i] % 2 == 0)
                {
                    nums.RemoveAt(i);
                }
            }

            // print nums list
            for (int i = 0; i < nums.Count; i++)
            {
                Console.WriteLine(nums[i]);            
            }
            Console.WriteLine();

            // bad removal
            nums.Clear();
            for (int i = 1; i <= 5; i++)
            {
                nums.Add(i);
            }
            for (int i = 0; i < nums.Count; i++)
            {
                if (nums[i] == 1 ||
                    nums[i] == 2 ||
                    nums[i] == 3)
                {
                    nums.RemoveAt(i);
                }
            }
            for (int i = 0; i < nums.Count; i++)
            {
                Console.WriteLine(nums[i]);
            }
            Console.WriteLine();

            Console.WriteLine();
        }
    }
}