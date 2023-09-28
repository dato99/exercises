using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace davaleba3
{
    internal class Program
    {
        static int NotContains(int[] array)
        {
            HashSet<int> uniqueIntegers = new HashSet<int>();

            foreach (int num in array)
            {
                uniqueIntegers.Add(num);
            }
            for (int i = 1; i <= int.MaxValue; i++)
            {
                if (!uniqueIntegers.Contains(i))
                {
                    return i;
                }
            }

            throw new InvalidOperationException("No solution found.");
        }
        static void Main(string[] args)
        {
            int[] array = { -1, 0, 1, 3, 5 };
            int result = NotContains(array);
            Console.WriteLine("The smallest positive integer not in the array is: " + result);
        }
    }
}
