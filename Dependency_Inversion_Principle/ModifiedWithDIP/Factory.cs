﻿ 
namespace ModifiedWithDIP
{
    public static class Factory
    {
        public static IPerson CreatePerson()
        {
            return new Person();
        }

        public static IChore CreateChore()
        {
            return new Chore(CreateLogger(), CreateMessageSender() );
        }

        public static IMessageSender CreateMessageSender()
        {
            return new Emailer();
        }

        public static ILogger CreateLogger()
        {
            return new Logger();
        }
    }
}

