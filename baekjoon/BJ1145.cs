public static class BJ1145
{
    public static void Solution_Fail()
    {
        int[] inputs = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

        List<int> items = new List<int>();
        List<int> result = new List<int>();

        for (int i = 0; i < inputs.Length; i++)
        {
            for (int j = 0; j < inputs.Length; j++)
            {
                if (i == j) continue;

                if (!items.Contains(inputs[i] * inputs[j]))
                {
                    items.Add(inputs[i] * inputs[j]);
                }
            }
        }

        for (int i = 0; i < items.Count; i++)
        {
            int count = 0;
            for (int j = 0; j < inputs.Length; j++)
            {
                if (items[i] % inputs[j] == 0)
                {
                    count++;
                }
            }

            if (count > 2)
            {
                result.Add(items[i]);
            }
        }

        Console.WriteLine(result.Min());
    }
    public static void Solution()
    {
        int[] inputs = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

        for (int i = 2; i < 1000000; i++)
        {
            int count = 0;
            for (int j = 0; j < inputs.Length; j++)
            {
                if (i % inputs[j] == 0)
                {
                    count++;
                }
            }

            if (count > 2)
            {
                Console.WriteLine(i);
                break;
            }
        }
    }

    public static void Solution_GDC()
    {
        int[] inputs = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

    }

    public static int GCD(int a, int b) //Greate Common Divisor 최대 공약수 
    {
        int r = a / b;

        if (r == 0) return r;

        a = b;
        b = r;

        return GCD(a, b);
    }

    public static int LCM(int a, int b)
    { //Least Common Multiple 최소 공배수
        return (a * b) / GCD(a, b);
    }
}