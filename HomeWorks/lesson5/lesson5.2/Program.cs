using System;
using System.IO;

namespace lesson5._2
{
    //Написать программу, которая при старте дописывает текущее время в файл «startup.txt».
    class Program
    {
        static void Main(string[] args)
        {
            File.AppendAllText("startup.txt", $"Программа была запущена в: {DateTime.Now}\n");
            Console.WriteLine("Время запуска программы было записано в файл startup.txt");

            Console.ReadKey();
        }
    }
}