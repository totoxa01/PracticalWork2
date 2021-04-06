using System;
using System.Collections.Generic;
using System.Text;

namespace PracticalWork2.Classes
{
    class ClassCheque
    {
        public static void Cheque()
        {
            int orderNumber = 120;
            DateTime date = new DateTime();
            Console.WriteLine("\t       ЗАО \"МОСКВА-МАКДОНАЛЬДС\"\n" +
                "\t  Москва, Волгоградский пр-кт, 24/2\n" +
                "\t\t WWW.MCDONALDS.ru\n" +
                "\tКОНТАКТ ЦЕНТР 8(495)7442999 С 9Д21\n" +
                "-----------------------------------------------\n" +
                "-----------------------------------------------\n" +
                "ККТ № 009007214\t\t\tИНН: 7710044132\n" +
                $"Заказ № {orderNumber}\n" +
                $"-----------------------------------------------\n" +
                $"\t\t*КАССОВЫЙ ЧЕК*\n" +
                $"\t\t   *ПРИХОД*\n" +
                $"латте\t\t    НДС 18%\t\t 99.00\n" +
                $"ИТОГ\t\t\t\t\t*99.00\n") ;

        }
    }
}
