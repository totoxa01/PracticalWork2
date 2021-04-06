using System;
using System.Collections.Generic;
using System.Text;

namespace PracticalWork2
{
    class ClassAverageDailyTemperature
    {
        private static double minTemperature;
        private static double maxTemperature;
               

        public static double AverageDailyTemperature()
        {
            Console.WriteLine("Введите минимальную температуру за сутки");
            minTemperature = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Введите максимальную температуру за сутки");
            maxTemperature = Int32.Parse(Console.ReadLine());
            double averageDaily = (minTemperature + maxTemperature) / 2;
            return averageDaily;
        }
    }
}
