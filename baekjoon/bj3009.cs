public static class bj3009
{
    public static void Solution()
    {
        List<int> firstItem = new List<int>();
        List<int> secondItem = new List<int>();

        for (int i = 0; i < 3; i++)
        {
            var item = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

            if (firstItem.Contains(item[0]))
            {
                firstItem.Remove(item[0]);
            }
            else
            {
                firstItem.Add(item[0]);
            }

            if (secondItem.Contains(item[1]))
            {
                secondItem.Remove(item[1]);
            }
            else
            {
                secondItem.Add(item[1]);
            }
        }
        Console.WriteLine("{0} {1}", firstItem[0], secondItem[0]);
    }
}