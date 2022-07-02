
namespace Single_Responsibility_Principle
{
    public class Program
    {
        static void Main(string[] args)
        {
            Messages.WelcomeMessage();

            Person person = PersonInfoCapture.Capture();

            bool isPersonValid = PersonValidator.Validate(person);

            if (!isPersonValid)
            {
                Messages.EndApplication();
                return;
            }

            EmailGenerator.Create(person);

            Messages.EndApplication(); 
        }





        public static void OldMainMethod()
        {
            #region Application Heading
            Console.WriteLine("Welcome to Single Responsibility Principle Example\n");
            #endregion


            #region Ask for person information
            Person person = new Person();

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
            string emailDraft = (person.FirstName.Substring(0, 1) + person.LastName).ToLower();
            person.EmailAdress = emailDraft + "company.com";
            Console.WriteLine($"Email Adress has been created: {person.EmailAdress}");
            #endregion


            Console.ReadKey();
        }
    } 
}