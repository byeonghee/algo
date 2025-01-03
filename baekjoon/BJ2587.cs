public static class BJ2587
{
    public static void Solution()
    {
        int[] inputs = new int[5];
        int sum = 0;

        for (int i = 0; i < 5; i++)
        {
            int input = int.Parse(Console.ReadLine());

            sum += input;
            inputs[i] = input;
        }

        Array.Sort(inputs);

        Console.WriteLine(sum / 5);
        Console.WriteLine(inputs[2]);

    }
}