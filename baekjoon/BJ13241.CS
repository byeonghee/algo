public static class BJ13241
{
    public static void Solution()
    {
        long[] input = Array.ConvertAll(Console.ReadLine().Split(' '), long.Parse);

        long A = input[0];
        long B = input[1];

        while (B != 0)
        {
            long temp = B;
            B = A % B;
            A = temp;
        }

        Console.WriteLine((input[0] * input[1] / A));

    }
}