public static class BJ12789
{
    public static void Solution()
    {
        int inputCount = int.Parse(Console.ReadLine());

        Queue<int> queue = new Queue<int>(Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse));
        Stack<int> stack = new Stack<int>();

        int count = 1;
        // 큐에 사람들이 있다. 
        // 사람들이 자신의 차례가 아니면 스택에 들어간다. 
        // 큐가 다 비워진다면 스택에서 찾는다.
        // 스택도 다 비워진다면
        while (true)
        {
            // 스택과 큐가 모두 비워진다면 "Nice"를 출력해준다.
            if (queue.Count == 0 && stack.Count == 0)
            {
                Console.WriteLine("Nice");
                break;
            }

            // 큐의 카운트가 0일 경우에 stack 에서 다음 값을 count 와 확인해본다.
            if (queue.Count == 0)
            {
                int s = stack.Pop();

                if (count == s)
                {
                    count++;
                }
                else
                {
                    Console.WriteLine("Sad");
                    break;
                }
            }
            else
            {
                // 큐에서 꺼낸 데이터가 count 와 같은지 확인한다.
                // 같으면 count 를 올려준다.
                if (count == queue.Peek())
                {
                    // 큐에서 데이터를 꺼낸다.
                    int q = queue.Dequeue();

                    count++;
                }
                // 다르다면 stack을 확인하고 스택값과 같다면 
                else if (stack.Count > 0 && count == stack.Peek())
                {
                    stack.Pop();
                    count++;
                }
                else // 큐의 데이터 와 스택에 데이터가 카운트와 안 맞을 경우에 큐에서 스택으로 옮겨준다.
                {
                    int q = queue.Dequeue();
                    stack.Push(q);
                }
            }
        }
    }
}