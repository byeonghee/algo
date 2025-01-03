public static class BJ11478
{
    public static void Solution()
    {
        string input = Console.ReadLine();

        HashSet<string> hs = new HashSet<string>();
        char[] items = input.ToCharArray();
        for (int i = 0; i < items.Length; i++)
        {
            string s = items[i].ToString();
            hs.Add(s);
            for (int j = i + 1; j < items.Length; j++)
            {
                s += items[j];

                hs.Add(s);
            }
        }

        Console.WriteLine(hs.Count);
    }
}