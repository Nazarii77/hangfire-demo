using System;

namespace Hangfire.Demo
{
    public class PrintJob : IPrintJob
    {
        public void Print()
        {
            Console.WriteLine($"Hangfire recurring job!");
        }
    }
}
