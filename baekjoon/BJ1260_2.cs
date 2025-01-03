using System.Runtime.CompilerServices;

public static class BJ1260_2
{
    static int N;
    static int M;
    static int T;

    static bool[,] graph;
    static bool[] visited;
    static List<int> dfsList;
    static List<int> bfsList;

    static void dfs(int first)
    {
        visited[first] = true;
        dfsList.Add(first);

        for (int i = 1; i <= N; i++)
            if (graph[first, i] && !visited[i])
                dfs(i);
    }

    static void bfs(int target)
    {
        Queue<int> queue = new Queue<int>();

        queue.Enqueue(target);
        visited[target] = true;
        bfsList.Add(target);

        while (queue.Count > 0)
        {
            int t = queue.Dequeue();

            for (int i = 1; i <= N; i++)
            {
                if (graph[t, i] && !visited[target])
                {
                    queue.Enqueue(i);
                    visited[i] = true;
                    bfsList.Add(i);
                }
            }
        }



    }
    public static void Solution()
    {
        System.IO.StreamReader sr = new System.IO.StreamReader("BJ1260.txt");
        int[] inputs = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);

        N = inputs[0];
        M = inputs[1];
        T = inputs[2];

        graph = new bool[N + 1, N + 1];
        visited = new bool[N + 1];

        dfsList = new List<int>();
        bfsList = new List<int>();

        for (int i = 0; i < T; i++)
        {
            int[] input = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);

            graph[input[0], input[1]] = true;
            graph[input[1], input[0]] = true;
        }

        dfs(T);
        visited = new bool[N + 1];
        bfs(T);
        Console.WriteLine(string.Join(' ', dfsList));
        Console.WriteLine(string.Join(' ', bfsList));
    }
}