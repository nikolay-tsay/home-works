using System;

namespace HomeWork2_1
{

    public enum Months :byte
    {
        January = 1,
        February,
        March,
        April,
        May,
        June,
        July,
        August,
        September,
        October,
        November,
        December,
    }
    class Program
    {
        static void Main(string[] args)
        {
        //Home Work 1,2,5.
            Console.WriteLine("Введите минимальную температуру за сутки");
            double minTemp = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите максимальную температуру за сутки");
            double maxTemp = double.Parse(Console.ReadLine());

            double avarageTemp = (minTemp + maxTemp) / 2;

            Console.WriteLine("Укажите порядковый номер месяца");
            int userMonth = int.Parse(Console.ReadLine());

            switch (userMonth)
            {
                case (byte)Months.January:
                    Console.WriteLine("Январь");
                    if (avarageTemp > 0)
                    {
                        Console.WriteLine("Дождливая зима");
                    }
                    break;
                case (byte)Months.February:
                    Console.WriteLine("Февраль");
                    if (avarageTemp > 0)
                    {
                        Console.WriteLine("Дождливая зима");
                    }
                    break;
                case (byte)Months.March:
                    Console.WriteLine("Март");
                    break;
                case (byte)Months.April:
                    Console.WriteLine("Апрель");
                    break;
                case (byte)Months.May:
                    Console.WriteLine("Май");
                    break;
                case (byte)Months.June:
                    Console.WriteLine("Июнь");
                    break;
                case (byte)Months.July:
                    Console.WriteLine("Июль");
                    break;
                case (byte)Months.August:
                    Console.WriteLine("Август");
                    break;
                case (byte)Months.September:
                    Console.WriteLine("Сентябрь");
                    break;
                case (byte)Months.October:
                    Console.WriteLine("Октябрь");
                    break;
                case (byte)Months.November:
                    Console.WriteLine("Ноябрь");
                    break;
                case (byte)Months.December:
                    Console.WriteLine("Декабрь");
                    if (avarageTemp > 0)
                    {
                        Console.WriteLine("Дождливая зима");
                    }
                    break;
                default:
                    Console.WriteLine("Нет такого месяца");
                    break;
            }
            Console.WriteLine($"Средняя температур за сутки: {avarageTemp}°C");
            Console.ReadKey();
        }
    }
}
