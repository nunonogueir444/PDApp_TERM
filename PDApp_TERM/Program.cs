namespace PDApp_TERM
{
    class Program
    {
        static void Main(string[] args)
        {

            //#########################################################################################

            ClassMachineDetails MachineDetailsInstance = new();
            MachineDetailsInstance.MachineDetails(args);

            ClassWriteArgs WriteArgsInstance = new();
            WriteArgsInstance.WriteArgs(args);

            //#########################################################################################

        }
    }
}