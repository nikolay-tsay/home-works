using System;

namespace HomeWork2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Проверка числа на четность
            Console.WriteLine("Введите любое число");

            string input = Console.ReadLine();
            double userNumber;
            bool result = double.TryParse(input, out userNumber);

            if (result == true)
            {
                if (userNumber % 2 == 0)
                {
                    Console.WriteLine("Число четное");
                }
                else
                    Console.WriteLine("Число нечетное");
            }
            else
                Console.WriteLine("Нужно ввести число");

            Console.ReadKey();
        }
    }
}
