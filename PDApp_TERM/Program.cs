namespace PDApp_TERM
{
    class Program
    {
        static void Main(string[] args)
        {

            //#########################################################################################

            ClassTruckDetails truckDetailsInstance = new();
            truckDetailsInstance.TruckDetails(args);

            ClassWriteArgs writeArgsInstance = new();
            writeArgsInstance.WriteArgs(args);

            //#########################################################################################

        }
    }
}