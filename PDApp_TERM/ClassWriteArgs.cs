using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDApp_TERM
{
    class ClassWriteArgs
    {
        public void WriteArgs(string[] args)
        {

        //#########################################################################################

            if (args.Length < 5)
            {
                Console.WriteLine("Passing Args error!");
                return;
            }

            /*Console.WriteLine("Truck Serial: " + args[0] + "   Tuck Model: " + args[1]
                              + "   Telematics: " + args[2] + "   Battery Type: " + args[3]);*/

            string[] labels = { "Truck Serial: ", "Truck Model: ", "Truck Index: ", "Telematics: ", "Battery Type: " };
            int maxLength = labels.Max(label => label.Length);

            for (int i = 0; i < labels.Length; i++)
            {
                Console.WriteLine(labels[i].PadRight(maxLength) + args[i]);
            }

            //#########################################################################################

        }
    }
}
