public static class BJ4949
{
    public static void Solution()
    {
        Stack<char> stack = new Stack<char>();
        System.Text.StringBuilder sb = new System.Text.StringBuilder();
        System.IO.StreamWriter sw = new System.IO.StreamWriter(Console.OpenStandardOutput());

        while (true)
        {
            char[] input = Console.ReadLine().ToCharArray();

            if (input.Length == 1 && input[0] == '.')
            {
                break;
            }

            bool isWrite = false;

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] != '(' && input[i] != ')' & input[i] != '[' & input[i] != ']') continue;
                if (input[i] == '(' || input[i] == '[')
                {
                    stack.Push(input[i]);
                }
                else if (input[i] == ')')
                {
                    if (stack.Count > 0 && stack.Peek() == '(')
                    {
                        stack.Pop();
                    }
                    else
                    {
                        sb.AppendLine("no");
                        isWrite = true;
                        break;
                    }
                }
                else if (input[i] == ']')
                {
                    if (stack.Count > 0 && stack.Peek() == '[')
                    {
                        stack.Pop();
                    }
                    else
                    {
                        sb.AppendLine("no");
                        isWrite = true;
                        break;
                    }

                }
            }

            if (!isWrite && stack.Count > 0)
            {
                sb.AppendLine("no");
            }
            else if (!isWrite)
            {
                sb.AppendLine("yes");
            }

            isWrite = false;

            stack.Clear();
        }

        sw.Write(sb);
        sw.Close();
    }
}