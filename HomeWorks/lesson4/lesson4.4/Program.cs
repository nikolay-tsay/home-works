using System;

namespace lesson4._4
{
    //Написать программу, вычисляющую число Фибоначчи для заданного значения рекурсивным способом. 
    
    class Program
    {
        static int Fibonachi(int num)
        {
            return num > 1 ? Fibonachi(num - 1) + Fibonachi(num - 2) : num;
        }
        
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число");
            string input = Console.ReadLine();
            int userNum;
            if (int.TryParse(input, out userNum))
                Console.WriteLine($"Число Фибоначчи для вашего значения: {Fibonachi(userNum)}");
            else
                Console.WriteLine("Нужно ввести число");

            Console.ReadLine();
        }
    }
}