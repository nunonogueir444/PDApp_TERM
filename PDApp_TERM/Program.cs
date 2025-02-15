using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDApp_TERM
{
    class Program
    {
        static void Main(string[] args)
        {
            //#########################################################################################

            if (args.Length < 2)
            {
                Console.WriteLine("Please provide two numeric arguments.");
                return;
            }

            if (int.TryParse(args[0], out int num1) && int.TryParse(args[1], out int num2))
            {
                int sum = num1 + num2;
                Console.WriteLine($"The sum of {num1} and {num2} is {sum}.");
            }
            else
            {
                Console.WriteLine("Both arguments must be valid integers.");
            }

            //#########################################################################################
        }
    }
}
