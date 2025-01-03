public static class BJ15652
{
    static int N;
    static int M;
    static int[] result;
    static System.Text.StringBuilder sb = new System.Text.StringBuilder();

    static System.IO.StreamWriter sw = new System.IO.StreamWriter(Console.OpenStandardOutput());
    public static void Solution()
    {
        int[] inputs = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

        N = inputs[0];
        M = inputs[1];

        result = new int[M];

        dfs(1, 0);

        sw.Write(sb);
        sw.Close();
    }

    public static void dfs(int num, int depth)
    {
        if (M == depth)
        {
            sb.AppendLine(string.Join(' ', result));
            return;
        }

        for (int i = num; i <= N; i++)
        {
            // Console.WriteLine("i: {0}, depth: {1}", i, depth);
            result[depth] = i;
            dfs(i, depth + 1);
        }
    }
}