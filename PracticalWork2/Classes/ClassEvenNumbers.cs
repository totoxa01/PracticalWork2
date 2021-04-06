using System;
using System.Collections.Generic;
using System.Text;

namespace PracticalWork2.Classes
{
    class ClassEvenNumbers
    {
        public static void EvenNumber()
        {
            Console.WriteLine("Введите число");
            int number = Int32.Parse(Console.ReadLine());
            if(number%2==0)
            {
                Console.WriteLine($" Число {number} - четное");
            }
            else 
            {
                Console.WriteLine($" Число {number} - не четное");
            }
        }
    }
}
