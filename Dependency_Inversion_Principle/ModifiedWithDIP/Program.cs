
namespace ModifiedWithDIP
{
    public class Program
    {
        public static void Process()
        {
            /*
             
            ==> Look at MessageSender File and see the difference from original project. 
                You should realize how easy we created a text message sender (texter). 

            ==> If I go to Factory and change the implementation of CreateMessageSender method such that it returns Texter
                then the message system will change and we will not changing anything else in the whole project.
                That is the power of Dependency Inversion Principle and SOLID in general (we used other principles as well)

             */

            IPerson owner = Factory.CreatePerson();
            owner.FirstName = "Onur";
            owner.LastName = "Derman";
            owner.EmailAdress = "onrdrmn@gmail.com";
            owner.PhoneNumber = "0212-111-11-11"; 

            IChore chore = Factory.CreateChore();
            chore.ChoreName = "Take out the trash";
            chore.Owner = owner; 

            chore.PerformedWork(3);
            chore.PerformedWork(1.5);
            chore.CompleteChore();




            Console.ReadLine();
        }
    }
}
