using System.Security.Cryptography.X509Certificates;

public static class BJ10448
{
    public static void Solution()
    {
        int inputCount = int.Parse(Console.ReadLine());

        int[] input = new int[inputCount];

        int[] values = new int[10000];

        List<int> items = new List<int>();

        for (int i = 0; i < inputCount; i++)
        {
            input[i] = int.Parse(Console.ReadLine());
        }

        int count = 1;
        while (true)
        {
            int item = count * (count + 1) / 2;

            if (1000 < item)
            {
                break;
            }
            items.Add(item);

            count++;
        }

        for (int i = 0; i < items.Count; i++)
        {
            for (int j = 0; j < items.Count; j++)
            {
                for (int k = 0; k < items.Count; k++)
                {
                    values[items[i] + items[j] + items[k]] = 1;
                }
            }
        }

        for (int i = 0; i < inputCount; i++)
        {
            Console.WriteLine(values[input[i]]);
        }
    }

    public static int T(int n)
    {
        return n * (n + 1) / 2;
    }
}