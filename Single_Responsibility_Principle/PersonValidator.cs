 
namespace Single_Responsibility_Principle
{
    public class PersonValidator
    {
        public static bool Validate(Person person)
        {
            if (string.IsNullOrEmpty(person.FirstName) || person.FirstName.StartsWith(" "))
            {
                Messages.ValidationError("First name");
                return false;
            }
            if (string.IsNullOrEmpty(person.LastName) || person.LastName.StartsWith(" "))
            {
                Messages.ValidationError("Last name");
                return false;
            }
            return true;
        }
    } 
}
