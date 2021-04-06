using System;
using System.Collections.Generic;
using System.Text;

namespace PracticalWork2.Classes
{
    class ClassMonths
    {
        public static void NameMonth()
        {
            Console.WriteLine("Введите порядковый номер текущего месяца");
            int number = Int32.Parse(Console.ReadLine());

            switch (number)
            {
                case 1:
                    Console.WriteLine("январь");
                    break;
                case 2:
                    Console.WriteLine("февраль");
                    break;
                case 3:
                    Console.WriteLine("март");
                    break;
                case 4:
                    Console.WriteLine("апрель");
                    break;
                case 5:
                    Console.WriteLine("май");
                    break;
                case 6:
                    Console.WriteLine("июнь");
                    break;
                case 7:
                    Console.WriteLine("июль");
                    break;
                case 8:
                    Console.WriteLine("август");
                    break;
                case 9:
                    Console.WriteLine("сентябрь");
                    break;
                case 10:
                    Console.WriteLine("октябрь");
                    break;
                case 11:
                    Console.WriteLine("ноябрь");
                    break;
                case 12:
                    Console.WriteLine("декабрь");
                    break;

            }
        }
    }
}
