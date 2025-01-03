public static class BJ2667
{
    static int N;
    static int count;
    static int[,] graph;
    static int[] dx = new int[4] { 0, 1, 0, -1 };
    static int[] dy = new int[4] { -1, 0, 1, 0 };
    static List<int> values = new List<int>();

    static void bfs(int x, int y)
    {
        Queue<Tuple<int, int>> queue = new Queue<Tuple<int, int>>();
        Tuple<int, int> tuple = new Tuple<int, int>(x, y);
        queue.Enqueue(tuple);

        bool[,] visited = new bool[N + 1, N + 1];

        while (queue.Count > 0)
        {
            var target = queue.Dequeue();
            visited[target.Item1, target.Item2] = true;

            graph[target.Item1, target.Item2] = 0;
            count += 1;

            for (int i = 0; i < 4; i++)
            {
                int newX = target.Item1 + dx[i];
                int newY = target.Item2 + dy[i];

                if (newX < 0 || N < newX || newY < 0 || N < newY || visited[newX, newY] || graph[newX, newY] == 0)
                {
                    continue;
                }

                queue.Enqueue(new Tuple<int, int>(newX, newY));
                visited[newX, newY] = true;
            }
        }
        values.Add(count);
    }
    public static void Solution()
    {
        // System.IO.StreamReader sr = new System.IO.StreamReader("q/BJ2667.txt");
        N = int.Parse(Console.ReadLine());

        graph = new int[N + 1, N + 1];
        count = 2;
        for (int i = 0; i < N; i++)
        {
            char[] c = Console.ReadLine().ToCharArray();

            for (int j = 0; j < c.Length; j++)
            {
                graph[i, j] = int.Parse(c[j].ToString());
            }
        }

        for (int i = 0; i < N; i++)
        {
            for (int j = 0; j < N; j++)
            {
                if (graph[i, j] == 1)
                {
                    count = 0;
                    bfs(i, j);
                }
            }
        }

        Console.WriteLine(values.Count);

        values.Sort();

        Console.WriteLine(string.Join("\n", values));
    }
}