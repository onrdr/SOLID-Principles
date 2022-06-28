 
namespace ModifiedWithoutOCP
{
    #region Changes Made After Original Project : 
    /*
    ******************** Changes in OCP_Library_2 File : ****************************** 
    1. IsManager and IsExecutive properties is added to EmployeeModel class  
    2. An enum class declared as EmployeeType is added  
    3. TypeOfEmployee property is added to PersonModel class  
    4. A switch statement has been added to Accounts class 
    
    ******************** Changes in Process Method in Program Class ******************** 
    1. Kobe Bryant's TypeOfEmplyee changed to Manager in applicants list  
    2. Jane Doe's TypeOfEmplyee changed to Executive in applicants list
    3. Second foreach statement that iterates employees list, has been modified

    ***** ==>> IMPORTANT : Modifications violates the OCP Principle. 
                           Because we we should be closed for modifications
    ***** ==>> PROBLEM   : What if the owner comes after a while and ask for 
                           adding technicians to the system. Are we going to modify all over again?    
    ***** ==>> REMAINDER : Open - Closed Principle ==> Open to Extension, Closed for Modification
    ***** ==>> GO TO     : ModifiedWithOCP File to see how we can handle these modifications 
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
                new PersonModel{ FirstName = "Jane", LastName = "Doe", TypeOfEmployee = EmployeeType.Executive},
                new PersonModel{ FirstName = "Kobe", LastName = "Bryant", TypeOfEmployee = EmployeeType.Manager},
            };
             
            foreach (var person in applicants)
            {
                employees.Add(accountProcessor.Create(person));
            }

            foreach (var emp in employees)
            {
                Console.WriteLine($"{emp.FirstName} {emp.LastName}: {emp.EmailAdress} " +
                    $"IsManager: {emp.IsManager} IsExecutive: {emp.IsExecutive}");
            } 
        }
    }
}