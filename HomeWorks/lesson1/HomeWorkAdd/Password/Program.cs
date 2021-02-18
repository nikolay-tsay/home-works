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
            int[] password = userPass.ToCharArray().Select(userPass => int.Parse(userPass.ToString())).ToArray();
            for (int j = 0; j <= userPass.Length; j++)
                {
                    //int[] password = userPass.ToCharArray().Select(i => int.Parse(i.ToString())).ToArray();
                    if (password[j] != password[j + 1] && userPass.Length <= 6 && userPass.Length >= 4)
                    {
                        continue;
                    }
                    else if (j >= userPass.Length)                
                    {
                        Console.WriteLine("Пароль подходит!");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Пароль не подходит!");
                        break;
                    }
                }
            Console.ReadKey();
            
        }
    }
}
