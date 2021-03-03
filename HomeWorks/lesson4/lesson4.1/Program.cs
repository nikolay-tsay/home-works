using System;

namespace lesson4._1
{
    /*Написать метод GetFullName(string firstName, string lastName, string patronymic),
     принимающий на вход ФИО в разных аргументах и возвращающий объединённую строку с ФИО. 
     Используя метод, написать программу, выводящую в консоль 3–4 разных ФИО.*/
    class Program
    {
        static void WriteFullName()
        {
            Console.Write("Введите ваше имя:");
            string firstName = Console.ReadLine();
            
            Console.Write("Введите вашу фамилию:");
            string lastName = Console.ReadLine();
            
            Console.Write("Введите ваше отчество:");
            string patronymic = Console.ReadLine();

            Console.WriteLine($"ФИО: {GetFullName(firstName, lastName, patronymic)}");

        }
        
        static string GetFullName(string firstName, string lastName, string patronymic)
        {
            return new string($"{lastName} {firstName} {patronymic}");
        }
        
        static void Main(string[] args)
        {
            WriteFullName();
            Console.ReadLine();
        }
    }
}