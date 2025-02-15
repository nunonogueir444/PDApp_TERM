using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDApp_TERM
{
    class ClassWriteArgs
    {
        public static void WriteArgs(string[] args)
        {

        //#########################################################################################

            if (args.Length < 4)
            {
                Console.WriteLine("Args missing!");
                return;
            }

            Console.WriteLine("Serial:" + args[0]
                              + "   Model:" + args[1]
                              + "   Matics:" + args[2]
                              + "   Bat:" + args[3]);
        

        //#########################################################################################

        }
    }
}
