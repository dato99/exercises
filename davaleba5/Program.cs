using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace davaleba5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int stairCount = 5; // Replace with the desired number of stairs
            int variants = CountVariants(stairCount);
            Console.WriteLine($"Number of ways to climb {stairCount} stairs: {variants}");
        }

        static int CountVariants(int stairCount)
        {
            if (stairCount <= 1)
            {
                return 1;
            }
            else
            {
                return CountVariants(stairCount - 1) + CountVariants(stairCount - 2);
            }
        }
    }
    
}
