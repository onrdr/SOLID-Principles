
namespace ModifiedWithLSP
{
    internal class CEO : BaseEmployee, IManager
    {
        public override void CalculatePerHourRate(int rank)
        {
            decimal baseAmount = 150M;

            Salary = baseAmount + rank;
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
