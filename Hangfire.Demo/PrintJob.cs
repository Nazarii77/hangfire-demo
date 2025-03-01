﻿using Quartz;
using System;

namespace Hangfire.Demo
{
    public class PrintJob : IPrintJob
    {
        public void Print()
        {
            CronExpression cronExpression = new CronExpression("0 * * ? * * *");
            DateTimeOffset nextScheduledTime = (DateTimeOffset)cronExpression.GetNextValidTimeAfter(DateTimeOffset.Now);
            Console.WriteLine("Hello Hangfire recurring job! Next message will run at: {0}", nextScheduledTime.DateTime);
        }
    }
}
