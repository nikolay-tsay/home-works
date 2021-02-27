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

        static void PrintArray(int[,] array)
        {
            Console.WriteLine("Исходный массив: ");
            for (int i = 0; i < array.GetLength(0); i++)
            { 
                Console.WriteLine("");
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write($" {array[i, j]}");
                }
            }
        }

        static void Main(string[] args)
        {
            Console.Write("Введите величину массива(n * n): ");
            string sizeInput = Console.ReadLine();
            int arraySize;
                if (int.TryParse(sizeInput, out arraySize) == false)
                {
                    Console.WriteLine("Нужно ввести число");
                }

            int[,] myArray = new int[arraySize, arraySize];
            
            myArray = GenerateArray(myArray);
            PrintArray(myArray);
            
            Console.Write("\nГлавная диагональ: ");
                for (int i = 0; i < myArray.GetLength(0); i++)
                {
                    Console.Write(myArray[i, i] + " ");
                }
                
            Console.Write("\nПротивоположная диагональ: ");
                for (int j = myArray.GetLength(0) - 1, i = 0; j >= 0; i++, j--)
                {
                    Console.Write(myArray[i, j] + " ");
                }
            
            Console.ReadLine();
        }
    }
}
