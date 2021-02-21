using System;
using System.Globalization;

namespace HomeWork2_1
{
    class Program
    {
        static void Main(string[] args)
        {
        //Home Work 1,2,5.
            Console.WriteLine("Введите минимальную температуру за сутки");
            string input1 = Console.ReadLine();
            double minTemp;
            bool result1 = double.TryParse(input1,out minTemp);
                if (result1 == false)
                {
                    Console.WriteLine("Нужно ввести число");
                    return;
                }
           
            Console.WriteLine("Введите максимальную температуру за сутки");
            string input2 = Console.ReadLine();
            double maxTemp;
            bool result2 = double.TryParse(input2, out maxTemp);
                if (result2 == false)
                {
                    Console.WriteLine("Нужно ввести число");
                    return;
                }

            double avarageTemp = (minTemp + maxTemp) / 2;

            Console.WriteLine("Укажите порядковый номер месяца");
            string input3 = Console.ReadLine();
            int userMonth;
            bool result3 = int.TryParse(input3, out userMonth);
                if (result3 == false)
                {
                    Console.WriteLine("Нужно ввести число");
                    return;
                }
                else if (userMonth > 12 || userMonth <= 0)
                {
                    Console.WriteLine("Такого месяца нет");
                    return;
                }

            DateTimeFormatInfo month = new 
            DateTimeFormatInfo();
            string getMonth = month.GetMonthName(userMonth).ToString();
            Console.WriteLine($"{getMonth}");
                if (userMonth == 1 || userMonth == 2 ||userMonth == 12)
                {
                    if (avarageTemp > 0)
                    {
                    Console.WriteLine("Дождливая зима");
                    }
                }

            Console.WriteLine($"Средняя температур за сутки: {avarageTemp}°C");
            Console.ReadKey();
        }
    }
}
