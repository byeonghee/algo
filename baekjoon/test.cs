public static class test
{
    public static void Solution()
    {
        int[] items = { 1, 2, 3, 4, 5 };

        Array.Sort(items, new IntComparer());

        Console.WriteLine(string.Join(' ', items));
    }

}