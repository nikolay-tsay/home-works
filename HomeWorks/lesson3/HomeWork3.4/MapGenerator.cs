namespace HomeWork3._4
{
    class MapGenerator
    {
        
        public char[,] GenerateMap()
        {
            return map;
        }

        public void SetMap(ShipGenerator ship)
        {
            for (int i = 1; i < mapSize - 1; i++)
            {
                for (int j = 1; j < mapSize - 1; j++)
                {
                    if (ship.GetShipPosition()[i, j] == 'X')
                    {
                        map[i, j] = 'X';
                    }
                }
            }
        }
        public void ClearMap()
        {
            for (int i = 0; i < mapSize; i++)
            {
                for (int j = 0; j < mapSize; j++)
                {
                    map[i, j] = '.';
                }
            }
        }
        
        
        public static int mapSize = 12;
        public static int shipsAmount = 10;
        private char[,] map;

        public MapGenerator()
        {
            map = new char[mapSize, mapSize];
            ClearMap();
        }
    }
}