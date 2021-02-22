using System;

namespace HomeWork2_3
{
    class Program
    {
        static void Main(string[] args)
        {

            Random generate = new Random();
            string[] itemsValue =  { "Молоко", "Хлеб", "Вода", "Боба" };
            string adress = "950456, Астраханская область,\n\t  город Щёлково, ул. Косиора, 43";
            string shopName = "Биба";
            string name = "Руслан Медведев";
            int billNumber = generate.Next(1, 5000);
            int fixBill = generate.Next(1, 9000);
            int code = generate.Next(1000, 9000);
            int fn = generate.Next(1000, 9000);
            long inn = generate.Next(10000000, 2000000000);

            int[] amount = new int[4];
                for (int i = 0; i < 4; i++)
                {
                    amount[i] = generate.Next(1, 8);
                }

            int[] price = new int[3];
                for (int i = 0; i < 3; i++)
                {
                    price[i] = generate.Next(10, 50);
                }

            Console.WriteLine($"\t\tКассовый чек №{billNumber}\n\t\t    ООО {shopName}\n\t Адрес {adress}\n\t\t ИИН {inn}\n\t\t{DateTime.Now}\n\t     Кассир: {name}");
                for (int i = 0; i <= 50; i++)
                {
                    Console.Write("*");
                }
            Console.WriteLine("\nПриход\nПродажа");
                for (int i = 0; i <= 50; i++)
                {
                    Console.Write("*");
                }
            Console.WriteLine("\nТовар\t\tКол-во\t\tСтоимость/шт.");
            Console.WriteLine($"\n{itemsValue[0]}\t\t{amount[0]} \t\t{price[0]}\n");
            Console.WriteLine($"{itemsValue[1]}\t\t{amount[1]} \t\t{price[1]}\n");
            Console.WriteLine($"{itemsValue[2]}\t\t{amount[2]} \t\t{price[2]}\n");
            Console.WriteLine($"{itemsValue[3]}\t\t{amount[3]} \t\tБесценен\n");
                for (int i = 0; i <= 50; i++)
                {
                    Console.Write("*");
                }

            int sum = 0;
                for (int i = 0; i < price.Length; i++)
                {
                    sum += amount[i] * price[i]; 
                }

            int clientPay = generate.Next(sum, 5000);
            int change = clientPay - sum;
            Console.WriteLine($"\nК оплате\t{sum}\nПолучено\t{clientPay}\nСдача\t\t{change}");
                for (int i = 0; i <= 50; i++)
                {
                    Console.Write("*");
                }
            Console.WriteLine($"\n\t  Система налогооблажения АААА\n\t\tФиск.чек №{fixBill}\n\t\t Код КАВО {code}\n\t\t    ФН {fn}\n\t\t   ООО {shopName}");
            Console.ReadKey();
        }
    }
}
