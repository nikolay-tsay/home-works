using System;

namespace HomeWork3._3
{
    //Написать программу, выводящую введенную пользователем строку в обратном порядке (olleH вместо Hello).

    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            char[] array = input.ToCharArray();
            
            for (int i = array.Length - 1; i <= array.Length; i--)
            {
                if (i < 0)
                    break;
                else
                    Console.Write(array[i]);
            }
            Console.ReadLine();
        }
    }
}
