using System;

namespace HomeWorks2_4
{
    public enum Days
    {
        Понедельник = 0b_00000000,
        Вторник = 0b_00000001,
        Среда = 0b_00000010,
        Четверг = 0b_00000100,
        Пятница = 0b_00001000,
        Суббота = 0b_00010000,
        Воскресенье = 0b_00100000,
    }
   /* public enum officeNum
    {
        Офис1 = 1,
        Офис2 = 2,
        Офис3 = 3,
        Офис4 = 4
    }*/

    class Program
    {
        static void Main(string[] args)
        {
            Days office1 = Days.Понедельник | Days.Среда | Days.Пятница;
            Console.Write("В каком офисе вы работаете?");
            int userOffice = int.Parse(Console.ReadLine());
            if (userOffice == 1)
            {
                Console.WriteLine($"Офис 1 работает в следующие дни: {office1}");
            }
        }
    }
}
