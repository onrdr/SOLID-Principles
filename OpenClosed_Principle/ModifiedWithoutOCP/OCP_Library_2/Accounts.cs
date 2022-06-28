 
namespace OCP_Library_2
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

            switch (person.TypeOfEmployee)
            {
                case EmployeeType.Staff:
                    break;
                case EmployeeType.Manager:
                    em.IsManager = true;
                    break;
                case EmployeeType.Executive:
                    em.IsManager = true;
                    em.IsExecutive = true;
                    break;
                default:
                    break;
            }
            return em;
        }
    }
}
