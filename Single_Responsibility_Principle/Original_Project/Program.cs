
namespace Original_Project
{
    public class Program
    {
        public static void Process()
        {

            /*
             * The Problem with this program is that it has so much responsibilities such as : 

             ==> First responsibility : Application Heading Region     

             ==> Second responsibility : Ask for person information  

             ==> Third responsibility : Validate person information

             ==> Forth responsibility : If person info is valid => create email adress  

             * Each responsibilities above should be done by a seperate class : 
               Look at modified version in ModifiedWithSRP folder int this project

             */
            #region Application Heading
            Console.WriteLine("Welcome to Single Responsibility Principle Example\n");
            #endregion


            #region Ask for person information
            Person person = new();

            Console.Write("Please enter your first name: ");
            person.FirstName = Console.ReadLine();

            Console.Write("Please enter your last name: ");
            person.LastName = Console.ReadLine();
            #endregion


            #region Validate person information
            if (string.IsNullOrEmpty(person.FirstName) || person.FirstName.StartsWith(" "))
            {
                Console.WriteLine("First name is not valid");
                Console.ReadKey();
                return;
            }
            if (string.IsNullOrEmpty(person.FirstName) || person.LastName.StartsWith(" "))
            {
                Console.WriteLine("Last name is not valid");
                Console.ReadKey();
                return;
            }
            #endregion


            #region If person info is valid => create email adress 
            string emailDraft = $"{person.FirstName[..1]}.{person.LastName}";

            person.EmailAdress = $"{emailDraft.ToLower()}@company.com";

            Console.WriteLine($"Email Adress has been created: {person.EmailAdress}");
            #endregion


            Console.ReadKey();
        }

         
    } 
}