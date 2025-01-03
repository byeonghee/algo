public static class BJ19532
{
    public static void Solution()
    {
        var inputs = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

        for (int i = -999; i < 1000; i++)
        {
            for (int j = -999; j < 1000; j++)
            {
                if (inputs[0] * i + inputs[1] * j == inputs[2] && inputs[3] * i + inputs[4] * j == inputs[5])
                {
                    Console.WriteLine("{0} {1}", i, j);
                    break;
                }
            }
        }
    }
}