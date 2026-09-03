using System;

class Program
{
    static void Main()
    {
        char[,] map =
        {
            { '#', '#', '#', '#', '#', '#', '#' },
            { '#', 'A', ' ', ' ', '#', ' ', '#' },
            { '#', ' ', '#', ' ', '#', ' ', '#' },
            { '#', ' ', '#', ' ', ' ', ' ', '#' },
            { '#', ' ', '#', '#', '#', ' ', '#' },
            { '#', ' ', ' ', ' ', ' ', 'G', '#' },
            { '#', '#', '#', '#', '#', '#', '#' }
        };

        int playerX = 1;
        int playerY = 1;

        while (true)
        {
            Console.Clear();

            // 맵 출력
            for (int y = 0; y < map.GetLength(0); y++)
            {
                for (int x = 0; x < map.GetLength(1); x++)
                {
                    if (x == playerX && y == playerY)
                        Console.Write('A');
                    else
                        Console.Write(map[y, x]);
                }

                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine("WASD로 움직이세요.");

            ConsoleKey key = Console.ReadKey(true).Key;

            int nextX = playerX;
            int nextY = playerY;

            if (key == ConsoleKey.W)
                nextY--;

            if (key == ConsoleKey.S)
                nextY++;

            if (key == ConsoleKey.A)
                nextX--;

            if (key == ConsoleKey.D)
                nextX++;

            // 벽이 아니면 이동
            if (map[nextY, nextX] != '#')
            {
                playerX = nextX;
                playerY = nextY;
            }

            // 목표 도착
            if (map[playerY, playerX] == 'G')
            {
                Console.Clear();
                Console.WriteLine("목표 도착!");
                break;
            }
        }
    }
}