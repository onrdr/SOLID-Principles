 
namespace Single_Responsibility_Principle
{
    public class PersonInfoCapture
    {
        public static Person Capture()
        {
            Person person = new Person();

            Console.Write("Please enter your first name: ");
            person.FirstName = Console.ReadLine();

            Console.Write("Please enter your last name: ");
            person.LastName = Console.ReadLine();

            return person; 
        } 
    } 
}
