using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Password
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите свой пароль");
            string userPass = (Console.ReadLine());
            int[] password = userPass.ToCharArray().Select(i => int.Parse(i.ToString())).ToArray();
            for (int j = 0; j <= userPass.Length; j++)
                {
                    //int[] password = userPass.ToCharArray().Select(i => int.Parse(i.ToString())).ToArray();
                    if (password[j] == password[j + 1] || userPass.Length > 6 || userPass.Length < 4)
                    {
                        Console.WriteLine("Пароль не подходит!");
                        return;
                    }
                    else
                    {
                       continue;
                    }
                }
            Console.WriteLine("Пароль подходит!");
            Console.ReadKey();
            
        }
    }
}
