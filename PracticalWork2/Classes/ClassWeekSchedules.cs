using System;
using System.Collections.Generic;
using System.Text;

namespace PracticalWork2.Classes
{
    class ClassWeekSchedules
    {
        public static void WeekSchedules() 
        {
            Console.WriteLine("Введите номер филиала");
            int number = Int32.Parse(Console.ReadLine());

            switch(number)
            {
                case 1:
                    Console.WriteLine($"Режим работы филиала {number}:\n" +
                        $"\tс понедельника по четверг с 09:00 до 18:00\n" +
                        $"\tпятница с 10:00 до 17:00\n" +
                        $"\tсуббота и воскресенье - выходной");
                    break;
                case 2:
                    Console.WriteLine($"Режим работы филиала {number}:\n" +
                        $"\tс понедельника по пятницу с 10:00 до 19:00\n" +
                        $"\tсуббота и воскресенье с 10:00 до 15:00");
                    break;
                case 3:
                    Console.WriteLine($"Режим работы филиала {number}:\n" +
                        $"\tс понедельника по пятницу с 10:00 до 16:00\n" +
                        $"\tсуббота и воскресенье - выходной");
                    break;
            }
        }
    }
}
