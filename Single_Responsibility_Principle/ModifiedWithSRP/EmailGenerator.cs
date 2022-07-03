
namespace ModifiedWithSRP
{
    public class EmailGenerator
    {
        public static void Create(Person person)
        {
            string emailDraft = $"{person.FirstName[..1]}.{person.LastName}";

            person.EmailAdress = $"{emailDraft.ToLower()}@company.com";

            Messages.EmailGeneratorSuccess(person);
        }
    }
}
