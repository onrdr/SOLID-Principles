
namespace Original_Project
{
    public class Accounts
    {
        public EmployeeModel Create(PersonModel person)
        {
            EmployeeModel em = new()
            {
                FirstName = person.FirstName,
                LastName = person.LastName,
                EmailAdress = $"{person.FirstName.Substring(0, 1)}.{person.LastName}".ToLower() + "@company.com"
            }; 
            return em;
        }
    }
}
