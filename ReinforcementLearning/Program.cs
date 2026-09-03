using System;
using System.Threading;

class Program
{
    static void Main()
    {
        char[,] map =
        {
            { '#', '#', '#', '#', '#', '#', '#' },
            { '#', ' ', ' ', ' ', '#', ' ', '#' },
            { '#', ' ', '#', ' ', '#', ' ', '#' },
            { '#', ' ', '#', ' ', ' ', ' ', '#' },
            { '#', ' ', '#', '#', '#', ' ', '#' },
            { '#', ' ', ' ', ' ', ' ', 'G', '#' },
            { '#', '#', '#', '#', '#', '#', '#' }
        };
        Random random = new Random();


        int aiX = 1;
        int aiY = 1;

        int steps = 0;
        
        while (true)
        {
            Console.Clear();

            // 맵 출력
            for (int y = 0; y < map.GetLength(0); y++)
            {
                for (int x = 0; x < map.GetLength(1); x++)
                {
                    if (x == aiX && y == aiY)
                        Console.Write('A');
                    else
                        Console.Write(map[y, x]);
                }

                Console.WriteLine();
            }

            Console.WriteLine();

            if (map[aiY, aiX] == 'G')
            {
                Console.WriteLine("🎉 AI가 목표에 도착했습니다!");
                break;
            }

            int action = random.Next(4);

            int nextX = aiX;
            int nextY = aiY;

            if (action == 0)
                nextY--;

            else if (action == 1)
                nextY++;

            else if (action == 2)
                nextX--;

            else if (action == 3)
                nextX++;

            // 벽이 아니면 이동
            if (map[nextY, nextX] != '#')
            {
                aiX = nextX;
                aiY = nextY;
            }

            steps++;

            // 움직이는 모습 보기
            Thread.Sleep(100);

        }
        Console.WriteLine();
        Console.WriteLine("프로그램 종료");
    }
}