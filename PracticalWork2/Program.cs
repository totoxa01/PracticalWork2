using System;

namespace PracticalWork2
{
    class Program
    {        
        static void Main(string[] args)
        {
            double temperature = ClassAverageDailyTemperature.AverageDailyTemperature();
            Console.WriteLine($"Среднесуточная температура: {temperature}");
            Console.WriteLine("------------------------------------------------");

            Console.WriteLine("Введите порядковый номер текущего месяца");
            int number = Int32.Parse(Console.ReadLine());
            Classes.ClassMonths.NameMonth(number);
            Console.WriteLine("------------------------------------------------");

            if ( temperature > 0 && (number <= 2 || number == 12))
            {
                Console.WriteLine("Дождливая зима");
            }
            Console.WriteLine("------------------------------------------------");

            Classes.ClassEvenNumbers.EvenNumber();
            Console.WriteLine("------------------------------------------------");

            Classes.ClassCheque.Cheque();
            Console.WriteLine("------------------------------------------------");

            Classes.ClassWeekSchedules.WeekSchedules();
        }
    }
}
