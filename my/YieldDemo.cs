using System.Security.Cryptography.X509Certificates;

public class YieldDemo
{
    private static int[] item = { 1, 2, 3, 4, 5 };
    public static void Solution()
    {
        var it = GetEnumerator();
        Console.WriteLine(it.Current);
        it.MoveNext();
        Console.WriteLine(it.Current);
        it.MoveNext();
        Console.WriteLine(it.Current);
        it.MoveNext();
        Console.WriteLine(it.Current);
        it.MoveNext();
        it.Reset();
    }

    public static IEnumerator<int> GetEnumerator()
    {
        for (int i = 0; i < item.Length; i++)
        {
            yield return item[i];
        }
    }
}