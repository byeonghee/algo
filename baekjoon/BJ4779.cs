public static class BJ4779
{
    public static void Solution()
    {
        string input;
        while ((input = Console.ReadLine()) != null)
        {
            int target = int.Parse(input);

            if (target == 0)
            {
                Console.WriteLine('-');
            }
            else
            {
                Console.WriteLine(UpCantor(0, target, "-"));
            }
        }
    }

    public static string UpCantor(int index, int Target, string result)
    {
        // 3 이라는 값이 들어온다면 1 에서 처리를 하고 result 에 처리된 값을 넣는다.

        // 1. index * 3 을 만들고 stringbuiler 에 Append를 해준다.
        if (index == Target)
        {
            return result;
        }

        System.Text.StringBuilder sb = new System.Text.StringBuilder();

        sb.Append(result);
        sb.Append(new string(' ', result.Length));
        sb.Append(result);

        result = sb.ToString();

        return UpCantor(index + 1, Target, result);
    }
    public static string DownCantor(int index)
    {
        if (index == 0) return "-";

        string result = DownCantor(index - 1);
        return result + new string(' ', result.Length) + result;
    }
}