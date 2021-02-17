using System;

namespace Password
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите свой пароль");
            string userPass = (Console.ReadLine());
            //char[] letters = userPass.ToCharArray();
            //char letters = userPass[0];

            for (int i = 0; i < userPass.Length - 1; i++)
            {
                if (userPass[i] == userPass[i + 1])
                {
                    Console.WriteLine("Одинаковые символы не должны идти подряд");
                    break;
                }
                else if (userPass.Length > 6)
                {
                    Console.WriteLine("Пароль слишком длинный!");
                    break;
                }
                else if (userPass.Length <4)
                {
                    Console.WriteLine("Пароль слишком короткий");
                    break;
                }
                else
                {

                }
                
            }
            Console.ReadKey();
            
        }
    }
}
