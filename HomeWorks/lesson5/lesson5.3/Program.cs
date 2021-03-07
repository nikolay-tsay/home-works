using System;
using System.IO;
using System.Linq;

namespace lesson5._3
{
    //Ввести с клавиатуры произвольный набор чисел (0...255) и записать их в бинарный файл.
    class Program
    {
        static byte[] GetArray(string input)
        {
            byte notNumber = 0;
            var array = input.Split(' ').Select(input=> byte.TryParse(input, out var num)? num : notNumber).ToArray();
            return array;
        }
        

        static void Main(string[] args)
        {
            Console.WriteLine("Введите произвольный набор чисел от 0 до 255 и разделите их пробелами");
            string userNum = Console.ReadLine();
            File.WriteAllBytes("bytes.bin", GetArray(userNum));
            Console.WriteLine("Числа были сохранены в файл bytes.bin");
            
            Console.ReadLine();
        }
    }
}