
namespace ModifiedWithSRP
{
    public class Program
    {
        public static void Process()
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
    }
}