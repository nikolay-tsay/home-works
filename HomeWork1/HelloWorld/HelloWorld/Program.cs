using System;

namespace lesson1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите свое имя: ");
            string name = Console.ReadLine();

            Console.WriteLine($"Привет, {name}, сейчас {DateTime.Now}");
            Console.ReadKey();
        }
    }
}
