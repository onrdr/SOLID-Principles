
namespace OCP_Library_2 
{ 
    public class PersonModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public EmployeeType TypeOfEmployee { get; set; } = EmployeeType.Staff; 
    }
}
