using System;

namespace Exercism_Introduction_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(AssemblyLine.SuccessRate(10));
            Console.WriteLine(AssemblyLine.ProductionRatePerHour(6));
            Console.WriteLine(AssemblyLine.WorkingItemsPerMinute(6));
            
        }
    }
}
