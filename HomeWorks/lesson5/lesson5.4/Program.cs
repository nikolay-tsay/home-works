using System;


namespace lesson5._4
{
    //Сохранить дерево каталогов и файлов по заданному пути в текстовый файл — с рекурсией и без.
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Задайте директорию");
            GetDirInfo newDir = new GetDirInfo(Console.ReadLine());
            //С рекурсией
            //GetDirInfo.Recursive();
            
            //Без рекурсии
            GetDirInfo.NotRecursive();
            
            Console.WriteLine("\nЭти данные были записаны в файл rootInfo.txt");

            Console.ReadKey();
        }
    }
}