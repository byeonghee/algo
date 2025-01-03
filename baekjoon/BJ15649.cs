// while 을 돌리면서 
using System.Runtime.CompilerServices;

public static class BJ15649
{
    // 1 부터 N 까지의 자연수에 M 개의 값을 넣을 곳
    static HashSet<string> set = new HashSet<string>();
    public static void Solution_TimeOver()
    {
        int[] inputs = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
        // 1 부터 N 까지의 자연수 중에 수열
        int N = inputs[0];
        // M 개의 갯수 리턴
        int M = inputs[1];

        string startIndex = "";
        string maxIndex = "";

        System.IO.StreamWriter sw = new System.IO.StreamWriter(Console.OpenStandardOutput());
        System.Text.StringBuilder sb = new System.Text.StringBuilder();

        for (int i = 1; i < M + 1; i++)
        {
            startIndex += i.ToString();
            maxIndex += "9";
        }

        for (int i = int.Parse(startIndex); i <= int.Parse(maxIndex); i++)
        {
            if (isContains(i.ToString(), N)) { set.Add(string.Join(' ', i.ToString().ToCharArray())); }
        }

        foreach (string v in set)
        {
            sb.AppendLine(v);
        }

        sw.WriteLine(sb);
        sw.Close();
    }

    public static bool isContains(string item, int N)
    {
        if (item.Contains('0')) { return false; }

        char[] items = item.ToCharArray();
        for (int i = 0; i < items.Length; i++)
        {
            if (N < int.Parse(items[i].ToString())) { return false; }
            for (int j = 0; j < items.Length; j++)
            {
                if (N < int.Parse(items[j].ToString())) { return false; }
                if (i != j && items[i] == items[j]) { return false; }
            }
        }

        return true;
    }

    static int N;
    static int M;
    static int[] result;
    static int[] visited;
    public static void dfs(int count)
    {
        if (count == M)
        {
            Console.WriteLine(string.Join(' ', result));
            return;
        }

        for (int i = 1; i <= N; i++)
        {
            if (visited[i] == 0)
            {
                Console.WriteLine("i : {0}, count : {1}", i, count);
                visited[i] = i + 1;
                result[count] = i;
                dfs(count + 1);
                visited[i] = 0;
            }

        }
    }


    public static void DFS(int count)
    {
        if (count == M) { return; }

        for (int i = 1; i <= M; i++)
        {
            if (visited[i] == 0)
            {
                visited[i] = 1;
                result[count] = i;
                DFS(count + 1);
                visited[i] = 0;

            }
        }
    }
    public static void Solution()
    {
        int[] input = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

        N = input[0];
        M = input[1];

        visited = new int[N + 1];
        result = new int[M];

        List<int> list = new List<int>();

        dfs(0);
    }


}