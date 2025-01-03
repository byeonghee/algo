public static class BJ1012
{
    static int M;
    static int N;
    static int[,] graph;
    static bool[,] visited;
    static int count;
    static int[] dx = new int[4] { 0, 1, 0, -1 };
    static int[] dy = new int[4] { -1, 0, 1, 0 };

    static void bfs(int x, int y)
    {
        Queue<Tuple<int, int>> queue = new Queue<Tuple<int, int>>();
        queue.Enqueue(new Tuple<int, int>(x, y));
        visited[x, y] = true;
        graph[x, y] = 0;
        while (queue.Count > 0)
        {
            var target = queue.Dequeue();

            for (int i = 0; i < 4; i++)
            {
                int newX = target.Item1 + dx[i];
                int newY = target.Item2 + dy[i];

                if (newX < 0 || M <= newX || newY < 0 || N <= newY || visited[newX, newY] || graph[newX, newY] == 0)
                {
                    continue;
                }

                queue.Enqueue(new Tuple<int, int>(newX, newY));
                graph[newX, newY] = 0;
                visited[newX, newY] = true;
            }
        }

        count++;
    }
    public static void Solution()
    {
        StreamReader sr = new StreamReader("q/BJ1012.txt");

        int TC = int.Parse(sr.ReadLine());

        count = 0;

        List<int> answer = new List<int>();

        for (int i = 0; i < TC; i++)
        {
            int[] inputs = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);

            M = inputs[0];
            N = inputs[1];
            int K = inputs[2];

            graph = new int[M, N];
            visited = new bool[M, N];

            for (int j = 0; j < K; j++)
            {
                int[] input = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);

                graph[input[0], input[1]] = 1;
            }

            for (int o = 0; o < M; o++)
            {
                for (int p = 0; p < N; p++)
                {
                    if (graph[o, p] == 1)
                    {
                        bfs(o, p);
                    }
                }
            }

            answer.Add(count);
            count = 0;
        }

        Console.WriteLine(string.Join('\n', answer));
    }
}