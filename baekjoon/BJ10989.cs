public static class BJ10989
{
    public static void Solution()
    {
        // int inputCount = int.Parse(Console.ReadLine());

        // Dictionary<int, int> items = new Dictionary<int, int>();
        // List<int> ints = new List<int>();
        // using (var sr = new System.IO.StreamReader(Console.OpenStandardInput()))
        // {
        //     for (int i = 0; i < inputCount; i++)
        //     {
        //         int input = int.Parse(sr.ReadLine());
        //         // Random random = new Random();
        //         // int input = random.Next(1, 10000);

        //         if (items.ContainsKey(input))
        //         {
        //             items[input] = items[input] + 1;
        //         }
        //         else
        //         {
        //             items.Add(input, 1);
        //             ints.Add(input);
        //         }
        //     }
        // }
        // ints.Sort();

        // using (var sw = new System.IO.StreamWriter(Console.OpenStandardOutput()))
        // {
        //     for (int i = 0; i < ints.Count; i++)
        //     {
        //         int count = 0;
        //         items.TryGetValue(ints[i], out count);

        //         for (int j = 0; j < count; j++)
        //         {
        //             sw.WriteLine(ints[i]);
        //         }
        //     }
        // }

        int inputCount = int.Parse(Console.ReadLine());
        int[] items = new int[10001];
        for (int i = 0; i < inputCount; i++)
        {
            int input = int.Parse(Console.ReadLine());

            items[input] += 1;
        }

        using (var sw = new System.IO.StreamWriter(Console.OpenStandardOutput()))
        {
            for (int i = 1; i <= 10000; i++)
            {
                for (int j = 0; j < items[i]; j++)
                {
                    sw.WriteLine(i);
                }
            }
        }
    }
}
