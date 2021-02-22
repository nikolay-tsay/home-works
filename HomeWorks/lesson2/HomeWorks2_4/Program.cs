using System;

namespace HomeWorks2_4
{
    [Flags]
    public enum Days 
    {
        Понедельник = 0b_00000001,
        Вторник =     0b_00000010,
        Среда =       0b_00000100,
        Четверг =     0b_00001000,
        Пятница =     0b_00010000,
        Суббота =     0b_00100000,
        Воскресенье = 0b_01000000
    }
    class Program
    {
        static void Main(string[] args)
        {
            Days officeMask1 = (Days)0b_00010101;
            Days officeMask2 = (Days)0b_00101010;
            Days officeMask3 = (Days)0b_00011011;
            Days officeMask4 = (Days)0b_00110110;

            Console.WriteLine("В каком офисе вы работаете?");
            string input = Console.ReadLine();
            int userNum;
            bool result = int.TryParse(input, out userNum);
                if (result == false)
                {
                    Console.WriteLine("Нужно ввести число");
                    return;
                }

            switch (userNum)
            {
                case 1:
                    Console.WriteLine($"Офис №1 работает в следующие дни: {officeMask1}");
                    break;
                case 2:
                    Console.WriteLine($"Офис №2 работает в следующие дни: {officeMask2}");
                    break;
                case 3:
                    Console.WriteLine($"Офис №3 работает в следующие дни: {officeMask3}");
                    break;
                case 4:
                    Console.WriteLine($"Офис №4 работает в следующие дни: {officeMask4}");
                    break;
                default:
                    Console.WriteLine("Офиса под таким номером нет");
                    break;
            }
            Console.ReadKey();
        }
    }
}
