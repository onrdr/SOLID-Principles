 
namespace OpenClosed_Principle
{
    internal class Run
    {
        static void Main(string[] args)
        { 
            Console.WriteLine("Open - Closed Principle : Open to EXtension, Closed for Modification\n");

            Original_Project.Program.Process();

            ModifiedWithoutOCP.Program.Process();

            ModifiedWithOCP.Program.Process();

            Console.ReadKey();
        }
    }
}
