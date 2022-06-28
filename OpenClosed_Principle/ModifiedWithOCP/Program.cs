 
namespace ModifiedWithOCP
{
    #region Changes Made After Original Project : 
    /*
    ==> The first big way to make sure that you can implement OCP is : 
        to NOT TIE YOURSELF DIRECTLY TO CLASSES. 
        So how we do that? : Of course BY CREATING INTERFACES...
    
    ******************** Changes in OCP_Library_3 File : ****************************** 
    1. Two Interfaces were added : IAccounts  and  IApplicantModel   
    2. Accounts class implemented IAccounts  and PersonModel class implemented IApplicantModel 
    3. ExecutiveAccounts and ManagerAccounts classes have been created and implemented IAccounts
    4. ExecutiveModel and ManagerModel classes have been created and implemented IApplicantModel 
    5. IsManager and IsExecutive properties are added to EmployeeModel class 
    6. AccountProcessor property has been added to PersonModel class

    ******************** Changes in Process Method in Program Class ******************** 
    1. applicant list modified to be a List<IApplicantModel> applicant and we add person, manager and executive
    2. accountProcessor object is deleted and instead we used person.AccountProcessor in the first foreach  
 
    */
    #endregion
    internal class Program
    {  
        public static void Process()
        {
            List<EmployeeModel> employees = new(); 
            List<IApplicantModel> applicants = new()
            {
                new PersonModel{ FirstName = "John", LastName = "Doe"},
                new ManagerModel{ FirstName = "Jane", LastName = "Doe"},
                new ExecutiveModel{ FirstName = "Kobe", LastName = "Bryant"} 
            };

            foreach (var person in applicants)
            {
                employees.Add(person.AccountProcessor.Create(person));
            }

            foreach (var emp in employees)
            {
                Console.WriteLine($"{emp.FirstName} {emp.LastName}: {emp.EmailAdress} " +
                    $"IsManager: {emp.IsManager} IsExecutive: {emp.IsExecutive}");
            } 
        }
    }
}