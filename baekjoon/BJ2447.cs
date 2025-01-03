public static class BJ2447
{
    public static void Solution()
    {
        int input = int.Parse(Console.ReadLine()); // 3 의 거듭제곱만들어옴 3, 9, 27, 81

        Console.WriteLine(DownStar(input, "*"));
    }

    public static string UpStar(int index, int target, string result)
    {
        if (Math.Pow(index - 1, 3) == target) return result;

        System.Text.StringBuilder sb = new System.Text.StringBuilder();

        string[] results = result.Split('\n');

        // for (int i = 0; i < 3; i++)
        // {
        //     for (int j = 0; j < 3; j++)
        //     {
        //         if (i == 1 && j == 1)
        //         {
        //             sb.Append(new string[' ', result.Length]);
        //         }
        //         else
        //         {
        //             sb.Append(result);
        //         }
        //     }
        //     sb.Append("\n");
        // }

        for (int i = 0; i < Math.Pow(index, 3); i++)
        {
            for (int j = 0; j < Math.Pow(index, 3); j++)
            {
                if (i == 1 && j == 1)
                {
                    sb.Append(new string[' ', result.Length]);
                }
                else
                {
                    sb.Append(result);
                }
            }
            sb.Append("\n");
        }

        result = sb.ToString();

        return UpStar(index + 1, target, result);
    }

    public static string DownStar(int index, string result)
    {

        if (index == 3) { return "***\n* *\n***"; }
        System.Text.StringBuilder sb = new System.Text.StringBuilder();
        result = DownStar(index / 3, result);
        string[] items = result.Split('\n');

        for (int i = 0; i < index; i++)
        {
            if (i < index / 3)
            {
                for (int j = 0; j < 3; j++)
                {
                    sb.Append(items[i % (index / 3)]);
                }
                sb.Append("\n");
            }
            else if (i < index * 2 / 3)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (j == 1)
                    {
                        sb.Append(new string(' ', items[j].Length));
                    }
                    else
                    {
                        sb.Append(items[i % (index / 3)]);

                    }
                }
                sb.Append("\n");
            }
            else
            {
                for (int j = 0; j < 3; j++)
                {
                    sb.Append(items[i % (index / 3)]);
                }
                if (i != index - 1)
                {
                    sb.Append("\n");
                }
            }
        }

        result = sb.ToString();

        return result;
    }
}