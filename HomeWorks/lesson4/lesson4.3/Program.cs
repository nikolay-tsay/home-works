using System;
using System.Diagnostics;

namespace lesson4._3
{
    /*Написать метод по определению времени года. На вход подаётся число – порядковый номер месяца.
     На выходе — значение из перечисления (enum) — Winter, Spring, Summer, Autumn. 
     Написать метод, принимающий на вход значение из этого перечисления и возвращающий название времени года (зима, весна, лето, осень). 
     Используя эти методы, ввести с клавиатуры номер месяца и вывести название времени года.
     Если введено некорректное число, вывести в консоль текст «Ошибка: введите число от 1 до 12».*/
    class Program
    {
        enum Seasons
        {
            Зима = 1,
            Весна,
            Лето,
            Осень
        }

        static string GetSeason(int num)
        {
            if (num == 12 || num == 1 || num == 2)
                return Seasons.Зима.ToString();
            else if (num == 3 || num == 4 || num == 5)
                return Seasons.Весна.ToString();
            else if (num == 6 || num == 7 || num == 8)
                return Seasons.Лето.ToString();
            else if (num == 9 || num == 10 || num == 11)
                return Seasons.Осень.ToString();
            else
                return new string("неизвестен, введите число от 1 до 12");
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Введите порядковый номер месяца");
            string input = Console.ReadLine();
            int userNum;
            if (int.TryParse(input, out userNum))
            {
                Console.WriteLine($"Сезон: {GetSeason(userNum)}");
            }
            else
                Console.WriteLine("Ошибка: введите число от 1 до 12");

            Console.ReadLine();
        }
    }
}
    