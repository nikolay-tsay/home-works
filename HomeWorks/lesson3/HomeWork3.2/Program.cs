using System;

namespace HomeWork3._2
{
    /* Написать программу — телефонный справочник — создать двумерный массив 5*2, хранящий список телефонных контактов: 
     * первый элемент хранит имя контакта, второй — номер телефона/e-mail.
     */

    class Program
    {
        static void Main(string[] args)
        {
            string[,] catalog = 
            { 
                {
                 "Рыбаков Глеб",
                 "Бородай Филипп",
                 "Бондаренко Артемий",
                 "Гончар Лев",
                 "Пестов Василий" 
                },
                
                {
                 "743-93-53",
                 "929-55-04",
                 "967-12-22",
                 "432-98-30",
                 "745-19-90" 
                } 
            };
            Console.WriteLine("\tТелефонный справочник\n");
            Console.WriteLine("\tИмя\t\t\tКонтакт\n");
            Console.WriteLine($"\t{catalog[0, 0]}\t\t{catalog[1, 0]}");
            Console.WriteLine($"\t{catalog[0, 1]}\t\t{catalog[1, 1]}");
            Console.WriteLine($"\t{catalog[0, 2]}\t{catalog[1, 2]}");
            Console.WriteLine($"\t{catalog[0, 3]}\t\t{catalog[1, 3]}");
            Console.WriteLine($"\t{catalog[0, 4]}\t\t{catalog[1, 4]}");
        }
    }
}
