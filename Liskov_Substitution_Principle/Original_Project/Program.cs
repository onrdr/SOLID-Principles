
namespace Original_Project
{
    #region The Problem with Original Project :
    /*
    ==> ************************* DEFINITION OF LSP : *************************
        LSP states that objects of a superclass should be replaceable with objects of its subclasses without breaking the application. 
        In other words, what we want is to have the objects of our subclasses behaving the same way as the objects of our superclass.
     
    ==> Example Problem 1:  In the code below, if we replace new Employee() to be new Manager(); we will not have a problem.
        However, if we replace new Employee() to be new CEO(), the program will throw an exception. 
        Beacuse, in CEO class, AssignManager() method is design to throw an exception, since a CEO cannot have a manager obviously.

                 Employee emp = new Employee()
                {
                    FirstName = "Stephen",
                    LastName = " Hawking"
                };
    ==> Example Problem 2: Lets say i want to check the rank of Manager and put an if statement inside CalculatePerHourRate() method
        if (rate < 0)
        {
            throw new Exception();
        }
        The problem is here is that, if we enter a value smaller than zero for the rank of Manager, the program will crash.
        However; It will not crash for a normal employee because it doesn't have a control inside its CalculatePerHourRate() method

    ==> So Generally; LSP is saying that if you have a child type or inherit type like CEO in this example, 
        this CEO should be able to put in place of wherever you see employee and not brake the application. 
        
    ==> The solution to these problems is to build it with interfaces. Look at the ModifiedWithLSP file.
    */
    #endregion
    public class Program
    {
        public static void Process()
        {
            Manager accountingVP = new()
            { 
                FirstName = "Marie",
                LastName = "Curie"
            };

            accountingVP.CalculatePerHourRate(4);

            Employee emp = new Manager()
            {
                FirstName = "Stephen",
                LastName = " Hawking"
            };

            emp.AssignManager(accountingVP);
            emp.CalculatePerHourRate(2);

            Console.WriteLine($"{emp.FirstName}'s salary is {emp.Salary}/hour");


            Console.ReadKey();
        }
    }
}