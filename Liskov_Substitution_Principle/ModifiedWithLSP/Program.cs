
namespace ModifiedWithLSP
{    
    public class Program
    {
        public static void Process()
        {
            IManager accountingVP = new CEO()
            { 
                FirstName = "Marie",
                LastName = "Curie"
            };

            accountingVP.CalculatePerHourRate(4);

            IManaged emp = new Employee()
            {
                FirstName = "Stephen",
                LastName = " Hawking"
            };

            emp.AssignManager(accountingVP);
            emp.CalculatePerHourRate(2); 

            Console.WriteLine($"{emp.FirstName}'s salary is {emp.Salary}/hour");
            Console.WriteLine($"{accountingVP.FirstName}'s salary is {accountingVP.Salary}/hour");


            Console.ReadKey();
        }
    }
}