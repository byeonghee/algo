public static class BJ10026
{
    static int N;
    static string[,] graph;
    static string[,] rgGraph;
    static bool[,] visited;
    static bool[,] rgVisited;
    static int[] dx = new int[4] { 0, 1, 0, -1 };
    static int[] dy = new int[4] { -1, 0, 1, 0 };

    static void dfs(int x, int y, string target, bool rg)
    {
        if (rg)
        {
            rgGraph[x, y] = "0";
            rgVisited[x, y] = true;

            for (int i = 0; i < 4; i++)
            {
                int newX = x + dx[i];
                int newY = y + dy[i];
                // if (newX < 0 || N < newX || newY < 0 || N < newY)
                // {
                //     continue;
                // }

                if (-1 < newX && newX < N && -1 < newY && newY < N)
                {
                    if (rgGraph[newX, newY] != target || rgVisited[newX, newY])
                    {
                        continue;
                    }

                    dfs(newX, newY, target, rg);
                }
            }
        }
        else
        {
            graph[x, y] = "0";
            visited[x, y] = true;

            for (int i = 0; i < 4; i++)
            {
                int newX = x + dx[i];
                int newY = y + dy[i];

                // if (newX < 0 || N < newX || newY < 0 || N < newY)
                // {
                //     continue;
                // }

                if (-1 < newX && newX < N && -1 < newY && newY < N)
                {
                    if (graph[newX, newY] != target || visited[newX, newY])
                    {
                        continue;
                    }

                    dfs(newX, newY, target, rg);
                }
            }
        }
    }

    public static void Solution()
    {
        // System.IO.StreamReader sr = new System.IO.StreamReader("q/BJ10026.txt");

        N = int.Parse(Console.ReadLine());
        graph = new string[N, N];
        rgGraph = new string[N + 1, N + 1];
        visited = new bool[N, N];
        rgVisited = new bool[N + 1, N + 1];

        int answer = 0;
        int rgAnswer = 0;

        // 그래프에 값 넣기
        for (int i = 0; i < N; i++)
        {
            char[] item = Console.ReadLine().ToCharArray();

            for (int j = 0; j < item.Length; j++)
            {
                graph[i, j] = item[j].ToString();
                if (item[j] == 'G')
                {
                    rgGraph[i, j] = "R";
                }
                else
                {
                    rgGraph[i, j] = item[j].ToString();
                }
            }
        }

        for (int i = 0; i < N; i++)
        {
            for (int j = 0; j < N; j++)
            {
                if (graph[i, j] != "0")
                {
                    dfs(i, j, graph[i, j], false);
                    answer += 1;
                }


                if (rgGraph[i, j] != "0")
                {
                    dfs(i, j, rgGraph[i, j], true);
                    rgAnswer += 1;
                }
            }
        }
        Console.WriteLine("{0} {1}", answer, rgAnswer);
    }
}