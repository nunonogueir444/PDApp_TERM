﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDApp_TERM
{
    class ClassTruckDetails
    {
        int truckIndex = 0;
        string?[] NodeID = new string?[127 + 1];

        public int Index { get; set; }
        public string? Model { get; set; }
        public string? TruckType { get; set; }
        public int Baudrate { get; set; }
        public string? ControllerType { get; set; }
        public string? ClearFaultsType { get; set; }

        public void TruckDetails(string[] args)
        {
            if (args.Length < 5)
            {
                Console.WriteLine("Truck Details Args error!");
                return;
            }

            truckIndex = int.Parse(args[2]);

            ClearNodeID();

            switch (truckIndex)
            {
                case 1000:
                    Model = args[1];
                    TruckType = "aaa";
                    Baudrate = 500;
                    ControllerType = "SE";
                    ClearFaultsType = "S";
                    NodeID[46] = "Master";
                    NodeID[50] = "Pump";
                    NodeID[120] = "Disp";
                    break;
                case 2000:
                    Model = args[1];
                    TruckType = "bbb";
                    Baudrate = 250;
                    ControllerType = "SE";
                    ClearFaultsType = "S_SH";
                    NodeID[47] = "TRR";
                    NodeID[48] = "TFR";
                    NodeID[49] = "TFL";
                    NodeID[50] = "Pump";
                    NodeID[120] = "Disp";
                    NodeID[125] = "CRR";
                    break;
                case 3000:
                    Model = args[1];
                    TruckType = "ccc";
                    Baudrate = 500;
                    ControllerType = "F";
                    ClearFaultsType = "F_SH";
                    NodeID[57] = "TFR";
                    NodeID[68] = "TFL";
                    NodeID[79] = "Pump";
                    NodeID[120] = "Disp";
                    break;
                default:
                    Model = "n/a";
                    TruckType = "n/a";
                    Baudrate = 0;
                    ControllerType = "n/a";
                    ClearFaultsType = "n/a";
                    break;
            }

            Console.WriteLine("-Tuck Model:        " + Model);
            Console.WriteLine("-Tuck Type:         " + TruckType);
            Console.WriteLine("-Baudrate:          " + Baudrate);
            Console.WriteLine("-Controller Type:   " + ControllerType);
            Console.WriteLine("-Clear Faults Type: " + ClearFaultsType);
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
                    Console.WriteLine($"NodeID[{i}] = {NodeID[i]}");
                }
            }
        }

    }
}
