public static class BJ1260
{
    static int N; // 정점의 갯수
    static int M; // 간선의 갯수
    static int V; // 탐색을 시작 할 수
    static bool[] visited;
    static bool[,] graph;
    static List<int> dfsList;
    static List<int> bfsList;


    public static void dfs(int idx)
    {
        // Console.WriteLine("dfs Idx = {0}", idx);
        dfsList.Add(idx);
        visited[idx] = true;

        for (int i = 1; i <= N; i++)
            if (!visited[i] && graph[idx, i])
                dfs(i);
    }

    public static void bfs(int idx)
    {
        Queue<int> queue = new Queue<int>();
        HashSet<int> hs = new HashSet<int>();
        bool[] visited = new bool[1001];

        queue.Enqueue(idx);
        hs.Add(idx);
        visited[idx] = true;

        while (queue.Count > 0)
        {
            int target = queue.Dequeue();

            for (int i = 1; i <= N; i++)
            {
                if (!visited[i] && graph[target, i])
                {
                    queue.Enqueue(i);
                    visited[i] = true;
                    hs.Add(i);
                }
            }
        }

        foreach (var item in hs)
        {
            bfsList.Add(item);
        }
    }
    public static void Solution()
    {
        int[] inputs = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

        N = inputs[0];
        M = inputs[1];
        V = inputs[2];

        graph = new bool[N + 1, N + 1];
        visited = new bool[N + 1];

        dfsList = new List<int>();
        bfsList = new List<int>();


        for (int i = 0; i < M; i++)
        {
            int[] input = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int x = input[0];
            int y = input[1];

            graph[x, y] = graph[y, x] = true;
        }

        dfs(V);
        bfs(V);

        Console.WriteLine(string.Join(' ', dfsList));
        Console.WriteLine(string.Join(' ', bfsList));
    }
}