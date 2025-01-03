public static class BJ15650
{
    static int N;
    static int M;
    static int[] result;
    static int[] visited;
    public static void Solution()
    {
        int[] inputs = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

        N = inputs[0];
        M = inputs[1];

        result = new int[M];
        visited = new int[N + 1];

        // dfs(0);
        dfs(1, 0);
    }
    public static void dfs(int num, int count)
    {
        if (count == M)
        {
            Console.WriteLine(string.Join(' ', result));
            return;
        }
        for (int i = num; i <= N; i++)
        {
            if (visited[i] == 0)
            {
                Console.WriteLine("i : {0}, count : {1}", i, count);
                visited[i] = 1;
                result[count] = i;
                dfs(i, count + 1);
                visited[i] = 0;
            }
        }
    }
    public static void dfs(int count)
    {
        if (count == M)
        {
            Console.WriteLine(string.Join(' ', result));
            return;
        }

        for (int i = 1; i <= N; i++)
        {
            bool isBigger = true;
            if (0 < count && i < result[count - 1])
            {
                isBigger = false;
            }
            if (visited[i] == 0 && isBigger)
            {
                // Console.WriteLine("i : {0}, count : {1}", i, count);
                visited[i] = 1 + 1;
                result[count] = i;
                dfs(count + 1);
                visited[i] = 0;
            }
        }
    }
}