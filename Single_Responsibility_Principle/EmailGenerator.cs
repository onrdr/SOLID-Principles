 
namespace Single_Responsibility_Principle
{
    public class EmailGenerator
    {
        public static void Create(Person person)
        {
            string emailDraft = $"{person.FirstName.Substring(0, 1)}.{person.LastName}";

            person.EmailAdress = $"{emailDraft.ToLower()}@company.com";

            Messages.EmailGeneratorSuccess(person);
        }
    } 
}
