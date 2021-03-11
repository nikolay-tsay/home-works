using System;

namespace lesson7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введит сообщение для теста");
            string massage = Console.ReadLine();
            Console.Clear();
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine($"Вывод {i}:{massage}");
            }
        }
    }
}