public class BJ1918
{
    public static void Solution()
    {
        // System.IO.StreamReader sr = new("q/후위 표기식.txt");
        System.IO.StreamReader sr = new(Console.OpenStandardInput());
        System.IO.StreamWriter sw = new(Console.OpenStandardOutput());

        char[] item = sr.ReadLine().ToCharArray();
        List<char> list = new();
        Stack<char> stack = new();

        for (int i = 0; i < item.Length; i++)
        {
            char c = item[i];

            if (c == '+' || c == '-' || c == '*' || c == '/' || c == '(' || c == ')')
            {
                if (stack.Count == 0)
                {
                    stack.Push(c);

                    continue;
                }

                if (c == '(')
                {
                    stack.Push(c);

                    continue;
                }

                if (c == ')')
                {
                    for (int j = 0; j < stack.Count; j++)
                    {
                        char val = stack.Peek();
                        if (val == '(')
                        {
                            stack.Pop();
                            break;
                        }
                        list.Add(stack.Pop());
                    }

                    continue;
                }

                if (c == '*' || c == '/')
                {
                    if (stack.Peek() == '*' || stack.Peek() == '/')
                    {
                        list.Add(stack.Pop());
                    }
                    stack.Push(c);

                    continue;
                }

                if (c == '+' || c == '-')
                {
                    while (stack.Count > 0)
                    {
                        if (stack.Peek() == ')')
                        {
                            stack.Pop();
                        }
                        else if (stack.Peek() == '*' || stack.Peek() == '/' || stack.Peek() == '+' || stack.Peek() == '-')
                        {
                            list.Add(stack.Pop());
                        }
                        else
                        {
                            stack.Pop();
                            break;
                        }
                    }

                    stack.Push(c);

                    continue;
                }
            }
            list.Add(c);
        }

        if (stack.Count > 0)
        {
            for (int j = 0; j <= stack.Count; j++)
            {
                list.Add(stack.Pop());
            }
        }

        while (stack.Count > 0)
        {
            list.Add(stack.Pop());
        }

        Console.WriteLine(string.Join("", list));
        Console.WriteLine(sr.ReadLine());
    }
}