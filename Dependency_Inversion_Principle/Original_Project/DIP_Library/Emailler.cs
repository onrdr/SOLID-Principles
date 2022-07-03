
namespace Original_Project
{
    public class Emailler
    {
        internal void SendEmail(Person person, string message)
        {
            Console.WriteLine($"Simulating sending an email to {person.EmailAdress}");
        }
    }
}
