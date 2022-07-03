
namespace Original_Project
{
    public class Program
    {
        public static void Process()
        {
            /*
                                ***** This program violates DIP *****
                                
            ==> It violates because; DIP states that HIGH level modules should not depend on LOW level modules  
                Rather both should depend on abstractions and these abstractions should not depend on details

            ==> High Level Modules are : Program class and Chore class 
                Because program class contains two other classes : Person and Chore 
                The Chore class also contains two other classes : Logger and Emailler 

            ==> Low Level Modules are : Emailler , Logger and Person classes because they dont contain any other classes

            ==> DIP says invert this dependency of high levels to low levels with abstraction. 
                To see the implementation => Look at the ModifiedWithDIP file in this project
                    
             */
            Person owner = new()
            {
                FirstName = "Onur",
                LastName = "Derman",
                EmailAdress = "onrdrmn@gmail.com",
                PhoneNumber = "0212-111-11-11"
            };

            Chore chore = new()
            {
                ChoreName = "Take out the trash",
                Owner = owner
            };

            chore.PerformedWork(3);
            chore.PerformedWork(1.5);
            chore.CompleteChore();




            Console.ReadLine();
        }
    }
}
