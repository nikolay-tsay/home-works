namespace HomeWork3._4
{
    class ShipGenerator
    {
        public char[,] GetShipPosition()
        {
            return shipPosition;
        }

        private bool ScanAround(int x, int y, MapGenerator map)
        {
            if (map.GenerateMap()[y, x + 1] != 'X' && map.GenerateMap()[y + 1, x + 1] != 'X' &&
                map.GenerateMap()[y + 1, x] != 'X' && map.GenerateMap()[y + 1, x - 1] != 'X' &&
                map.GenerateMap()[y, x - 1] != 'X' && map.GenerateMap()[y - 1, x - 1] != 'X' &&
                map.GenerateMap()[y - 1, x] != 'X' && map.GenerateMap()[y - 1, x + 1] != 'X')
            {
                return true;
            }
            else
                return false;
        }

        public bool SetShipPosition(int x, int y, MapGenerator map)
        {
            if (map.GenerateMap()[y, x] != 'X' && shipSize != 1)
            {
                if (isHorizontal)
                {
                    if ((x + shipSize) < MapGenerator.mapSize - 1)
                    {
                        for (int i = 0; i < shipSize; i++)
                        {
                            if (ScanAround(x + i, y, map) == false)
                            {
                                return false;
                            }
                        }

                        for (int i = 0; i < shipSize; i++)
                        {
                            shipPosition[y, x + i] = 'X';
                        }

                        map.SetMap(this);
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    if ((y + shipSize) < MapGenerator.mapSize - 1)
                    {
                        for (int i = 0; i < shipSize; i++)
                        {
                            if (ScanAround(x, y + i, map) == false)
                            {
                                return false;
                            }
                        }

                        for (int i = 0; i < shipSize; i++)
                        {
                            shipPosition[y + i, x] = 'X';
                        }
                        map.SetMap(this);
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            else if (map.GenerateMap()[y, x] != 'X' && shipSize == 1)
            {
                if (ScanAround(x, y, map))
                {
                    shipPosition[y, x] = 'X';
                    map.SetMap(this);
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
                return false;
        }

        public void ClearShips()
        {
            for (int i = 0; i < MapGenerator.mapSize; i++)
            {
                for (int j = 0; j < MapGenerator.mapSize; j++)
                {
                    shipPosition[i, j] = '\0';
                }
            }
        }
        

        private char[,] shipPosition;
        private int shipSize;
        private bool isHorizontal;
        
        public bool Horizont
        {
            get { return isHorizontal; }
            set { isHorizontal = value; }
        }

        public ShipGenerator(int size, bool horizont)
        {
            this.shipSize = size;
            shipPosition = new char[MapGenerator.mapSize, MapGenerator.mapSize];
            this.isHorizontal = horizont;
            ClearShips();
        }
    }
}