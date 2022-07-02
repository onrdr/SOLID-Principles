

namespace Single_Responsibility_Principle
{
    public class Messages
    {
        public static void WelcomeMessage()
        {
            Console.WriteLine("==================================================\n" +
                "Welcome to Single Responsibility Principle Example\n" +
                "==================================================");
        }
        public static void EndApplication()
        {
            Console.WriteLine("==================================================" +
                   "\n\nPress any key to exit");
            Console.ReadKey();
        }
        public static void ValidationError(string fieldAdi)
        {
            Console.WriteLine($"{fieldAdi} is not valid");
        }
        public static void EmailGeneratorSuccess(Person person)
        {
            Console.WriteLine($"Email Adress has been created: {person.EmailAdress}");
        }
    } 
}
