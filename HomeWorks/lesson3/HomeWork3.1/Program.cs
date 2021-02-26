using System;

namespace HomeWork3._1
{
    //Написать программу, выводящую элементы двухмерного массива по диагонали
    class Program
    {
        static int[,] GenerateArray(int[,] array)
        {
            Random random = new Random();
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                   array[i, j] += random.Next(1, 9);
                }
            }
            return array;
        }  

        static void Main(string[] args)
        {
            int[,] myArray = new int[10, 10];
            myArray = GenerateArray(myArray);

            Console.WriteLine("Исходный массив: ");
                for (int i = 0; i < myArray.GetLength(0); i++)
                {
                    Console.WriteLine("");
                    for (int j = 0; j < myArray.GetLength(1); j++)
                    {
                        Console.Write($" {myArray[i, j]}");
                    }
                }
            

        }
    }
}
