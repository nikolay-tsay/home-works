using System;
using System.IO;

namespace lesson5._1
{

    //Ввести с клавиатуры произвольный набор данных и сохранить его в текстовый файл.
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите данные, которые нужно сохранить.");
            File.WriteAllText("file1.txt", Console.ReadLine());
            Console.WriteLine("Данные сохранены в файле file1.txt");
            
            Console.ReadKey();
        }
    }
}