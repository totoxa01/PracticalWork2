using System;

namespace PracticalWork2
{
    class Program
    {        
        static void Main(string[] args)
        {
            Console.WriteLine($"Среднесуточная температура: {ClassAverageDailyTemperature.AverageDailyTemperature()}");
            Classes.ClassMonths.NameMonth();
        }
    }
}
