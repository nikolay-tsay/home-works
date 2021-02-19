using System;

namespace HomeWork2_3
{
    class Program
    {
        static void Main(string[] args)
        {

            Random generate = new Random();
            int amount = generate.Next(1, 5);
            string[,] itemsValue =  { { "Молоко", "Хлеб", "Вода", "Боба" },{"30", "15", "10", "Бесценен"}};
            string adress = "950456, Астраханская область,\n\t  город Щёлково, ул. Косиора, 43";
            int billNumber = generate.Next(1, 5000);
            int fixBill = generate.Next(1, 9000);
            int code = generate.Next(1, 9000);
            int fn = generate.Next(1, 9000);
            int change = generate.Next(5000);
            long inn = generate.Next(1, 2000000000);
            string shopName = "Биба";
            string name = "Руслан Медведев";

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
            Console.WriteLine($"\n{itemsValue[0,0]}\t\t{amount} \t\t{itemsValue[1,0]}\n");
            Console.WriteLine($"{itemsValue[0, 1]}\t\t{amount} \t\t{itemsValue[1, 1]}\n");
            Console.WriteLine($"{itemsValue[0, 2]}\t\t{amount} \t\t{itemsValue[1, 2]}\n");
            Console.WriteLine($"{itemsValue[0, 3]}\t\t{amount} \t\t{itemsValue[1, 3]}\n");
            for (int i = 0; i <= 50; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine($"\nНаличными\t55\nСдача\t\t{change}");
            for (int i = 0; i <= 50; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine($"\n\t  Система налогооблажения АААА\n\t\tФиск.чек №{fixBill}\n\t\t Код КАВО {code}\n\t\t    ФН {fn}\n\t\t   ООО {shopName}");

            Console.ReadKey();
        }
    }
}
