using System;
using System.Linq;

namespace lesson4._2
{
    /*Написать программу, принимающую на вход строку — набор чисел, разделенных пробелом,
     и возвращающую число — сумму всех чисел в строке.
     Ввести данные с клавиатуры и вывести результат на экран.*/
    class Program
    {
        static void SumOfAll(string str)
        {
            int result = 0;
            var array =str.Split(' ').Select(Int32.Parse).ToArray();
            //Так и не понял, как тут обработать исключение, если ввести не числа.
            for (int i = 0; i < array.Length; i++)
            {
                result += array[i];
            }
            
            Console.WriteLine($"Сумма всех чисел: {result}");
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку чисел и разделите их пробелами");
            string userStr = Console.ReadLine();
            
            SumOfAll(userStr);

            Console.ReadLine();
        }
    }
}