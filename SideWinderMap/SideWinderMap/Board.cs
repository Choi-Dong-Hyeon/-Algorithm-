using System;

class Board
{
    const char CIRCLE = '\u25cf';
    public int[,] _tile;
    public int _size;

    public enum TileType
    {
        Empty,
        Wall,
    }

    public void Init(int size)
    {
        if (size % 2 == 0) return;

        _tile = new int[size, size];
        _size = size;

        SideWinderMap();
    }

    void SideWinderMap()
    {

        for (int y = 0; y < _size; y++)
        {
            for (int x = 0; x < _size; x++)
            {
                if (x % 2 == 0 || y % 2 == 0)
                    _tile[y, x] = (int)TileType.Wall;
                else
                    _tile[y, x] = (int)TileType.Empty;
            }
        }


        Random rand = new Random();
        for (int y = 0; y < _size; y++)
        {
            int count = 1;
            for (int x = 0; x < _size; x++)
            {
                if (x % 2 == 0 || y % 2 == 0)
                    continue;

                if (y == _size - 2 && x == _size - 2)
                    continue;

                if (y == _size - 2)
                {
                    _tile[y, x + 1] = (int)TileType.Empty;
                    continue;
                }

                if (x == _size - 2)
                {
                    _tile[y + 1, x] = (int)TileType.Empty;
                    continue;
                }

                if (rand.Next(0, 2) == 0)
                {
                    _tile[y, x + 1] = (int)TileType.Empty;
                    count++;
                }
                else
                {
                    int randomIndex = rand.Next(0, count);
                    _tile[y + 1, x - randomIndex * 2] = (int)TileType.Empty;
                    count = 1;
                }
            }
        }

    }


    public void Render()
    {
        for (int y = 0; y < _size; y++)
        {
            for (int x = 0; x < _size; x++)
            {
                Console.ForegroundColor = GetTileColor((TileType)_tile[y, x]);
                Console.Write(CIRCLE);
            }
            Console.WriteLine();
        }
    }

    ConsoleColor GetTileColor(TileType type)
    {
        switch (type)
        {
            case TileType.Empty:
                return ConsoleColor.Green;
            case TileType.Wall:
                return ConsoleColor.Red;
            default:
                return ConsoleColor.Green;
        }
    }
}

