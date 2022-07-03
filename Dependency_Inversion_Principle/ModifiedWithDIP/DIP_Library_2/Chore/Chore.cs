
namespace ModifiedWithDIP
{
    public class Chore : IChore
    {
        readonly ILogger _logger;

        readonly IMessageSender _messageSender;
        public string ChoreName { get; set; }
        public IPerson Owner { get; set; }
        public double HoursWorked { get; set; }
        public bool IsComplete { get; set; }

        public Chore(ILogger logger, IMessageSender messageSender)
        {
            _logger = logger;
            _messageSender = messageSender;
        }
        public void PerformedWork(double hours)
        {
            HoursWorked += hours;
            _logger.Log($"Performed work on {ChoreName}");
        }

        public void CompleteChore()
        {
            IsComplete = true;
            _logger.Log($"Completed {ChoreName}");
            _messageSender.SendMessage(Owner, $"The Chore {ChoreName} is complete");
        }
    }
}
