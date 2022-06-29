
namespace ModifiedWithLSP
{
    public class Employee : BaseEmployee, IManaged
    {
        public IEmployee Manager { get; set; } = null; 

        public virtual void AssignManager(Employee manager)
        {
            Manager = manager;
        } 

    }
}
