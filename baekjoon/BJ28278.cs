using System.Text;

public static class BJ28278
{
    public static void Solution()
    {
        Stack<int> stack = new Stack<int>();
        System.Text.StringBuilder sb = new System.Text.StringBuilder();
        System.IO.StreamWriter sw = new System.IO.StreamWriter(Console.OpenStandardOutput());

        int inputCount = int.Parse(Console.ReadLine());
        string[] inputs = new string[inputCount];

        for (int i = 0; i < inputCount; i++)
        {
            string input = Console.ReadLine();
            if (input.Length > 2)
            {
                int[] item = Array.ConvertAll(input.Split(' '), int.Parse);

                stack.Push(item[1]);
            }
            else if (int.Parse(input) == 2)
            {
                if (stack.Count > 0)
                {
                    sb.AppendLine(stack.Pop().ToString());
                }
                else
                {
                    sb.AppendLine("-1");
                }
            }
            else if (int.Parse(input) == 3)
            {
                sb.AppendLine(stack.Count.ToString());
            }
            else if (int.Parse(input) == 4)
            {
                if (stack.Count > 0)
                {
                    sb.AppendLine("0");
                }
                else
                {
                    sb.AppendLine("1");
                }
            }
            else if (int.Parse(input) == 5)
            {
                if (stack.Count > 0)
                {
                    sb.AppendLine(stack.Peek().ToString());
                }
                else
                {
                    sb.AppendLine("-1");
                }
            }
        }
        // Console.WriteLine("---------------");
        sw.Write(sb);
        sw.Close();
    }
}