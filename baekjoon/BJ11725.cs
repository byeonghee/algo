public static class BJ11725
{
    static int N;
    // static int[,] graph;
    static List<int>[] graph2;

    static int[] parent;
    static bool[] visited;

    static void dfs(int idx)
    {
        visited[idx] = true;

        // for (int i = 1; i <= N; i++)
        // {
        //     if (graph[idx, i] == 1 && !visited[i])
        //     {
        //         parent[i] = idx;
        //         dfs(i);
        //     }
        // }

        foreach (var item in graph2[idx])
        {
            if (!visited[item])
            {
                parent[item] = idx;
                dfs(item);
            }
        }
    }
    public static void Solution()
    {
        System.Text.StringBuilder sb = new System.Text.StringBuilder();
        System.IO.StreamReader sr = new System.IO.StreamReader("q/BJ11725.txt");
        // System.IO.StreamReader sr = new System.IO.StreamReader(Console.OpenStandardInput());
        System.IO.StreamWriter sw = new System.IO.StreamWriter(Console.OpenStandardOutput());
        N = int.Parse(sr.ReadLine());

        // graph = new int[N + 1, N + 1];
        graph2 = new List<int>[N + 1];
        parent = new int[N + 1];
        visited = new bool[N + 1];
        Dictionary<int, List<int>> keyValuePairs = new Dictionary<int, List<int>>();

        for (int i = 1; i <= N; i++)
        {
            graph2[i] = new List<int>();
        }
        for (int i = 0; i < N - 1; i++)
        {
            int[] input = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);

            // graph[input[0], input[1]] = graph[input[1], input[0]] = 1;

            graph2[input[0]].Add(input[1]);
            graph2[input[1]].Add(input[0]);
        }

        dfs(1);

        for (int i = 2; i < parent.Length; i++)
        {
            sb.AppendLine(parent[i].ToString());
        }

        sw.WriteLine(sb);

        sw.Close();
    }
}