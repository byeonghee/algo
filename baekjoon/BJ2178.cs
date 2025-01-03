public static class BJ2178
{
    static int N;
    static int M;
    static int[,] graph;
    static bool[,] visited;
    static int[] dx = new int[4] { 0, 1, 0, -1 };
    static int[] dy = new int[4] { -1, 0, 1, 0 };

    public static void bfs(int x, int y)
    {
        Queue<Tuple<int, int>> queue = new Queue<Tuple<int, int>>();
        queue.Enqueue(new Tuple<int, int>(x, y));
        visited[x, y] = true;

        while (queue.Count > 0)
        {
            Tuple<int, int> tuple = queue.Dequeue();

            for (int i = 0; i < 4; i++)
            {
                int nowX = tuple.Item1 + dx[i];
                int nowY = tuple.Item2 + dy[i];

                if (nowX < 0 || nowY < 0 || graph[nowX, nowY] == 0 || visited[nowX, nowY])
                {
                    continue;
                }
                // if (nowX > N || nowY > M)
                // {
                //     continue;
                // }
                if (nowX > N) { continue; }
                if (nowY > M) { continue; }

                Console.WriteLine("x: {0} y: {1} valeu: {2}", nowX, nowY, graph[nowX, nowY]);

                graph[nowX, nowY] = graph[tuple.Item1, tuple.Item2] + 1;
                queue.Enqueue(new Tuple<int, int>(nowX, nowY));
                visited[nowX, nowY] = true;
            }
        }
    }

    public static void bfs2(int x, int y)
    {
        Queue<Tuple<int, int>> queue = new Queue<Tuple<int, int>>();

        queue.Enqueue(new Tuple<int, int>(x, y));
        visited[x, y] = true;

        while (queue.Count > 0)
        {
            var item = queue.Dequeue();

            for (int i = 0; i < 4; i++)
            {
                int newX = item.Item1 + dx[i];
                int newY = item.Item2 + dy[i];

                if (newX < 0 || N < newX || newY < 0 || M < newY || visited[newX, newY] || graph[newX, newY] != 1)
                {
                    continue;
                }

                Console.WriteLine("x: {0}, y: {1}, value: {2}", newX, newY, graph[item.Item1, item.Item2] + 1);

                graph[newX, newY] = graph[item.Item1, item.Item2] + 1;
                visited[newX, newY] = true;
                queue.Enqueue(new Tuple<int, int>(newX, newY));
            }

        }
    }
    public static void Solution()
    {
        // int[] inputs = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

        StreamReader sr = new StreamReader("input.txt");

        int[] inputs = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);

        N = inputs[0];
        M = inputs[1];

        graph = new int[N + 1, M + 1];
        visited = new bool[N + 1, M + 1];

        for (int i = 0; i < N; i++)
        {
            char[] input = sr.ReadLine().ToCharArray();

            for (int j = 0; j < M; j++)
            {
                graph[i, j] = int.Parse(input[j].ToString());
            }
        }

        // dfs(0, 0, 1);
        bfs2(0, 0);

        Console.WriteLine(graph[N - 1, M - 1]);
    }
}

// 4 6
// 101111
// 101010
// 101011
// 111011