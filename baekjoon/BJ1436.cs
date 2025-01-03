public static class BJ1436
{
    public static void Solution()
    {
        int input = int.Parse(Console.ReadLine());

        float count = 0;
        float i = 666;

        while (true)
        {
            if (i.ToString().Contains("666"))
            {
                count++;
            }

            if (input == count)
            {
                break;
            }
            i++;
        }

        Console.WriteLine(i);
    }
}