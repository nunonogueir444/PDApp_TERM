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

            if (args.Length < 4)
            {
                Console.WriteLine("Please provide all arguments.");
                return;
            }

            /*if (int.TryParse(args[0], out int num1) && int.TryParse(args[1], out int num2))
            {
                int sum = num1 + num2;
                Console.WriteLine($"The sum of {num1} and {num2} is {sum}.");
            }
            else
            {
                Console.WriteLine("Both arguments must be valid integers.");
            }*/

            Console.WriteLine("Arguments provided: " + "Serial:" + args[0] 
                                                     + "   Model:" + args[1] 
                                                     + "   Matics:" + args[2] 
                                                     + "   Bat:" + args[3]);

            //#########################################################################################
        }
    }
}
