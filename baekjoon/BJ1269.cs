using System.Security.Cryptography.X509Certificates;

public static class BJ1269
{
    public static void Solution()
    {
        int[] AB = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
        int result = 0;

        HashSet<int> A = new HashSet<int>(Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse));

        HashSet<int> B = new HashSet<int>(Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse));

        foreach (var i in A)
        {
            if (!B.Contains(i))
            {
                result++;
            }
        }

        foreach (var i in B)
        {
            if (!A.Contains(i))
            {
                result++;
            }
        }

        Console.WriteLine(result);
    }
}