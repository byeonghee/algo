public static class BJ11724
{
    static int N;
    static int M;
    static int[,] graph;
    static bool[] visited;

    static void dfs(int idx)
    {
        visited[idx] = true;

        Console.WriteLine("idx: {0}", idx);
        for (int i = 1; i <= N; i++)
        {
            if (!visited[i] && graph[idx, i] == 1)
            {
                dfs(i);
            }
        }
    }
    public static void Solution()
    {
        StreamReader sr = new StreamReader("q/BJ11724.txt");

        int[] input = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);
        int answer = 0;

        N = input[0];
        M = input[1];

        graph = new int[N + 1, N + 1];
        visited = new bool[N + 1];

        for (int i = 0; i < M; i++)
        {
            int[] item = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);
            graph[item[0], item[1]] = graph[item[1], item[0]] = 1;
        }
        for (int i = 1; i <= N; i++)
        {
            if (!visited[i])
            {
                dfs(i);
                answer += 1;
            }
        }

        Console.WriteLine(answer);
    }
}