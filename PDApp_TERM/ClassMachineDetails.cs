using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDApp_TERM
{
    class ClassMachineDetails
    {
        int MachineIndex = 0;
        int pad = 20;
        readonly string?[] NodeID = new string?[127 + 1];

        public string? MachineModel { get; set; }
        public string? MachineType { get; set; }
        public int Baudrate { get; set; }
        public string? MotorType { get; set; }
        public string? ClearFaultsType { get; set; }

        public void MachineDetails(string[] args)
        {
            if (args.Length < 4)
            {
                Console.WriteLine("Machine Details Args error!");
                return;
            }

            MachineIndex = int.Parse(args[1]);

            ClearNodeID();

            switch (MachineIndex)
            {
                case 1000:
                    MachineModel = "a";
                    MachineType = "aaa";
                    Baudrate = 500;
                    MotorType = "SE";
                    ClearFaultsType = "A";
                    NodeID[33] = "M";
                    NodeID[44] = "P";
                    NodeID[100] = "HMI";
                    break;
                case 2000:
                    MachineModel = "b";
                    MachineType = "bbb";
                    Baudrate = 250;
                    MotorType = "SE";
                    ClearFaultsType = "C";
                    NodeID[24] = "TBR";
                    NodeID[48] = "TAR";
                    NodeID[55] = "TAL";
                    NodeID[57] = "P";
                    NodeID[99] = "HMI";
                    NodeID[111] = "CRR";
                    break;
                case 3000:
                    MachineModel = "c";
                    MachineType = "ccc";
                    Baudrate = 500;
                    MotorType = "F";
                    ClearFaultsType = "A";
                    NodeID[54] = "TAR";
                    NodeID[63] = "TAL";
                    NodeID[72] = "P";
                    NodeID[120] = "HMI";
                    break;
                case 4000:
                    MachineModel = "d";
                    MachineType = "ddd";
                    Baudrate = 500;
                    MotorType = "F";
                    ClearFaultsType = "A";
                    NodeID[57] = "TAR";
                    NodeID[68] = "TAL";
                    NodeID[79] = "P";
                    NodeID[88] = "TRE";
                    NodeID[125] = "HMI";
                    break;
                case 5000:
                    MachineModel = "e";
                    MachineType = "eee";
                    Baudrate = 250;
                    MotorType = "SE";
                    ClearFaultsType = "D";
                    NodeID[57] = "TFR";
                    NodeID[68] = "TFL";
                    NodeID[69] = "P";
                    NodeID[71] = "TBL";
                    NodeID[79] = "TBR";
                    NodeID[82] = "SFR";
                    NodeID[88] = "SBR";
                    NodeID[122] = "HMI";
                    break;
                case 6000:
                    MachineModel = "f";
                    MachineType = "fff";
                    Baudrate = 500;
                    MotorType = "SE";
                    ClearFaultsType = "G";
                    NodeID[57] = "TFR";
                    NodeID[68] = "TFL";
                    NodeID[69] = "TBL";
                    NodeID[79] = "P";
                    NodeID[123] = "HMI";
                    break;
                default:
                    MachineModel = "n/a";
                    MachineType = "n/a";
                    Baudrate = 0;
                    MotorType = "n/a";
                    ClearFaultsType = "n/a";
                    break;
            }



            Console.WriteLine("Machine Model:".PadRight(pad) + MachineModel);
            Console.WriteLine("Machine Type:".PadRight(pad) + MachineType);
            Console.WriteLine("Baudrate:".PadRight(pad) + Baudrate);
            Console.WriteLine("Motor Type:".PadRight(pad) + MotorType);
            Console.WriteLine("Clear Faults Type:".PadRight(pad) + ClearFaultsType);
            PrintNonNullNodes();
            Console.WriteLine("");

        }

        public void ClearNodeID()
        {
            for (int i = 0; i < NodeID.Length; i++)
            {
                NodeID[i] = null;
            }
        }

        public void PrintNonNullNodes()
        {
            for (int i = 0; i < NodeID.Length; i++)
            {
                if (!string.IsNullOrEmpty(NodeID[i]))
                {
                    Console.WriteLine($"NodeID 0x{i}:".PadRight(pad) + NodeID[i]);
                }
            }
        }

    }
}
