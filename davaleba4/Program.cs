using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace davaleba4
{
    using System;
    using System.Collections.Generic;

    public class ParenthesesValidator
    {
        public static bool IsProperly(string sequence)
        {
            Stack<char> stack = new Stack<char>();

            foreach (char c in sequence)
            {
                if (c == '(')
                {
                    stack.Push(c);
                }
                else if (c == ')')
                {
                    if (stack.Count == 0 || stack.Pop() != '(')
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                }
            }

            return stack.Count == 0;
        }

        public static void Main(string[] args)
        {
            string validSequence = "(()())";
            string invalidSequence = "())()";

            Console.WriteLine("IsValid for validSequence: " + IsProperly(validSequence)); // Should print True
            Console.WriteLine("IsValid for invalidSequence: " + IsProperly(invalidSequence)); // Should print False
        }
    }

}
