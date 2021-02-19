using System;

namespace HomeWork2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Проверка числа на четность
            Console.WriteLine("Введите любое число");
            double userNumber = double.Parse(Console.ReadLine());

            if (userNumber%2 == 0)
            {
                Console.WriteLine("Число четное");
            }
            else
                Console.WriteLine("Число нечетное");

            Console.ReadKey();
        }
    }
}
