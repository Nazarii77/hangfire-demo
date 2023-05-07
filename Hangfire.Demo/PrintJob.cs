using Quartz;
using System;

namespace Hangfire.Demo
{
    public class PrintJob : IPrintJob
    {
        public void Print()
        {
            CronExpression cronExpression = new CronExpression("0/10 * * * * ? *");
            DateTimeOffset nextScheduledTime = (DateTimeOffset)cronExpression.GetNextValidTimeAfter(DateTimeOffset.UtcNow);
            Console.WriteLine("Hello Hangfire recurring job! This mesage was run at: {0}", nextScheduledTime.DateTime);
        }
    }
}
