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

            if (args.Length < 4)
            {
                Console.WriteLine("Passing Args error!");
                return;
            }

            string[] labels = { "Machine Serial: ", "Machine Index: ", "Antenna: ", "Battery Type: " };
            int maxLength = labels.Max(label => label.Length);

            for (int i = 0; i < labels.Length; i++)
            {
                Console.WriteLine(labels[i].PadRight(maxLength) + args[i]);
            }

            //#########################################################################################

        }
    }
}
