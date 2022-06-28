 
namespace Original_Project
{
    #region Information about the project and the process
   /*  
    * This is a basic project that processes applicants into employee and then 
      creates Email Adresses for each of the employees.

    * After a while, owner of the company asks for a change that they want to have a way 
      to identify that an employee is whether a simple employee or a manager or an executive etc... 

    * The modified version without "Open-closed Principle" is in the ModifiedWithoutOCP 
      file in this project. Go and check it out after looking at the original project
      so that you can easily differentiate the modifications.

    */ 
    #endregion
    internal class Program
    {
        public static void Process()
        {
            List<EmployeeModel> employees = new();
            Accounts accountProcessor = new();
            List<PersonModel> applicants = new()
            {
                new PersonModel{ FirstName = "John", LastName = "Doe"},
                new PersonModel{ FirstName = "Jane", LastName = "Doe"},
                new PersonModel{ FirstName = "Kobe", LastName = "Bryant"},
            };

            foreach (var person in applicants)
            {
                employees.Add(accountProcessor.Create(person));
            } 

            foreach (var emp in employees)
            {
                Console.WriteLine($"{emp.FirstName} {emp.LastName}: {emp.EmailAdress}");
            }  
        }
    }
}