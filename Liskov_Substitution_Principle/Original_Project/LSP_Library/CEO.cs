
namespace Original_Project
{
    internal class CEO : Employee
    {
        public override void CalculatePerHourRate(int rank)
        {
            decimal baseAmount = 150M;

            Salary = baseAmount + rank;
        }

        public override void AssignManager(Employee manager)
        {
            throw new InvalidOperationException("The CEO has no manager");
        }

        public void GeneratePerformanceReview()
        {
            Console.WriteLine("I'm reviewing performance of direct report");
        }

        public void FireSomeone()
        {
            Console.WriteLine("You are fired!");
        }
    }
}
