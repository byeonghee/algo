public static class BJ1977
{
    public static void Solution()
    {
        int M = int.Parse(Console.ReadLine());
        int N = int.Parse(Console.ReadLine());

        List<int> items = new List<int>();
        int count = 1;

        while (true)
        {
            int item = count * count;
            if (N < item)
            {
                break;
            }
            if (M <= item && item <= N)
            {
                items.Add(count * count);
            }
            count++;
        }

        int sum = 0;
        for (int i = 0; i < items.Count; i++)
        {
            sum += items[i];
        }
        if (items.Count > 0)
        {
            Console.WriteLine(sum);
            Console.WriteLine(items.Min());
        }
        else Console.WriteLine(-1);
    }
}