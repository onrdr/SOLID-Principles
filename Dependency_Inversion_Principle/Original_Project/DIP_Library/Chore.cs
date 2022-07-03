
namespace Original_Project
{
    public class Chore
    {
        public string ChoreName { get; internal set; }
        public Person Owner { get; internal set; }
        public double HoursWorked { get; set; }
        public bool IsComplete { get; set; }

        internal void PerformedWork(double hours)
        {
            HoursWorked += hours;

            Logger log = new();
            log.Log($"Performed work on {ChoreName}");
        }

        internal void CompleteChore()
        {
            IsComplete = true;

            Logger log = new();
            log.Log($"Completed {ChoreName}");

            Emailler emailler = new();
            emailler.SendEmail(Owner, $"The Chore {ChoreName} is complete");
        }
    }
}
