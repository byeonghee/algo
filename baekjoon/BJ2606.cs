public static class BJ2606
{
    static bool[,] graph;
    static bool[] visited;
    static int N;
    static int M;
    static int answer;

    public static void dfs(int idx)
    {
        visited[idx] = true;
        answer++;

        for (int i = 1; i <= N; i++)
            if (!visited[i] && graph[idx, i])
                dfs(i);
    }
    public static void Solution()
    {
        N = int.Parse(Console.ReadLine());

        M = int.Parse(Console.ReadLine());

        visited = new bool[N + 1];
        graph = new bool[N + 1, N + 1];

        for (int i = 0; i < M; i++)
        {
            int[] target = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

            int x = target[0];
            int y = target[1];

            graph[x, y] = graph[y, x] = true;
        }

        dfs(1);

        Console.WriteLine(answer - 1);
    }
    public static void MySolution()
    {
        int computerCount = int.Parse(Console.ReadLine());

        int conn = int.Parse(Console.ReadLine());
        int[,] list = new int[conn, 2];
        Queue<int> que = new Queue<int>();
        HashSet<int> hs = new HashSet<int>();
        int result = 0;

        for (int i = 0; i < conn; i++)
        {
            int[] target = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

            list[i, 0] = target[0];
            list[i, 1] = target[1];
        }

        que.Enqueue(1);

        while (true)
        {
            if (que.Count == 0)
            {
                break;
            }

            int target = que.Dequeue();

            for (int i = 0; i < conn; i++)
            {
                // Console.WriteLine(list[i, 0]);
                if (list[i, 0] == target)
                {
                    list[i, 0] = 0;
                    que.Enqueue(list[i, 1]);
                    hs.Add(list[i, 1]);
                    list[i, 1] = 0;
                }

                if (list[i, 1] == target)
                {
                    list[i, 1] = 0;
                    que.Enqueue(list[i, 0]);
                    hs.Add(list[i, 0]);
                    list[i, 0] = 0;
                }
            }
        }

        Console.WriteLine(hs.Count);
    }
}