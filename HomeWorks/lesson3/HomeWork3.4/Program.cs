using System;

namespace HomeWork3._4
{
    //«Морской бой» — вывести на экран массив 10х10, состоящий из символов X и O, где Х — элементы кораблей, а О — свободные клетки.

    class Program
    {
        static void DrawMap(MapGenerator map)
        {
            char a = 'A';
            for (int i = 0; i < MapGenerator.mapSize - 1; i++)
            {
                if (i != 10)
                    Console.Write(" " + i + " ");
                else
                    Console.Write(" " + i + "");

                for (int j = 1; j < MapGenerator.mapSize - 1; j++)
                {
                    if (i == 0)
                        Console.Write(" " + a++ + " ");
                    else
                    {
                        if (map.GenerateMap()[i, j] == 'X')
                            Console.Write(" X ");
                        else
                            Console.Write(" . ");
                    }
                }
                Console.WriteLine();
            }
        }
        static void CreateShips(ShipGenerator[] ships)
        {
            Random random = new Random();
            for (int i = 0; i < MapGenerator.shipsAmount; i++)
            {
                if (i == 0)
                {
                    ships[i] = new ShipGenerator(4, random.Next(2) > 0);
                }
                else if (i > 0 && i <= 2)
                {
                    ships[i] = new ShipGenerator(3, random.Next(2) > 0);
                }
                else if (i > 2 && i <= 5)
                {
                    ships[i] = new ShipGenerator(2, random.Next(2) > 0);
                }
                else if (i > 5 && i < 10)
                {
                    ships[i] = new ShipGenerator(1, random.Next(2) > 0);
                }
            }
        }

        static void SetShipsPosition(ShipGenerator[] ships, MapGenerator map)
        {
            Random random = new Random();
            int i = 0;
            while (i < MapGenerator.shipsAmount)
            {
                if (ships[i].SetShipPosition(random.Next(1, 11), random.Next(1, 11), map))
                {
                    i++;
                }
            }
        }
        static void ClearShips(ShipGenerator[] ships)
        {
            Random random = new Random();
            for (int i = 0; i < MapGenerator.shipsAmount; i++)
            {
                ships[i].ClearShips();
                ships[i].Horizont = (random.Next(2) > 0);
            }
        }
        static void ResetMap(MapGenerator map, ShipGenerator[] ships)
        {
            map.ClearMap();
            ClearShips(ships);
            SetShipsPosition(ships, map);
        }
        
        
        static void Main(string[] args)
        {
            ShipGenerator[] ships = new ShipGenerator[MapGenerator.shipsAmount];
            MapGenerator map = new MapGenerator();
            CreateShips(ships);
            SetShipsPosition(ships, map);

            while (true)
            {
                DrawMap(map);
                Console.WriteLine("Нажмите пробел для расстановки кораблей");
                Console.WriteLine();
                if (Console.ReadKey().Key == ConsoleKey.Spacebar)
                {
                    ResetMap(map, ships);
                    Console.Clear();
                }
                else
                    break;
            }
        }
    }
}
