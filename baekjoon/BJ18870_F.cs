public static class BJ18870_F
{
    public static void Solution()
    {
        int N = int.Parse(Console.ReadLine());
        int[] X = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

        HashSet<int> hs = new HashSet<int>();
        for (int i = 0; i < N; i++)
        {
            hs.Add(X[i]);
        }

        var s = hs.OrderBy(c => c);

        Console.WriteLine(1);
    }
}