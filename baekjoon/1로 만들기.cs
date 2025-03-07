public class BJ1463
{
    public static void Solution()
    {
        int input = int.Parse(Console.ReadLine());
        int[] item = new int[input + 1];

        item[1] = 0;
        for (int i = 2; i <= input; i++)
        {
            int min = int.MaxValue;

            if (i % 3 == 0)
            {
                if (item[i / 3] < min)
                {
                    min = item[i / 3];
                }
            }
            if (i % 2 == 0)
            {
                if (item[i / 2] < min)
                {
                    min = item[i / 2];
                }
            }

            if (item[i - 1] < min)
            {
                min = item[i - 1];
            }

            item[i] = min + 1;
        }

        Console.WriteLine(item[input]);
   }
    public static void Solution2()
    {
        int n = int.Parse(Console.ReadLine());

        Queue<(int value, int step)> queue = new();

        HashSet<int> visited = new();

        queue.Enqueue((n, 0));

        while (queue.Count > 0)
        {
            var current = queue.Dequeue();

            // 최종으로 current.value 가 1이 되었을 경우만 리턴해준다.
            if (current.value == 1)
            {
                Console.WriteLine(current.step);

                return;
            }

            // 3으로 나누어 지고 방문을 하지 않았다면 방문 처리와 큐에 넣어준다.
            if (current.value % 3 == 0 && !visited.Contains(current.value / 3))
            {
                queue.Enqueue((current.value / 3, current.step + 1));
                visited.Add(current.value / 3);

            }
            if (current.value % 2 == 0 && !visited.Contains(current.value / 2))
            {
                queue.Enqueue((current.value / 2, current.step + 1));
                visited.Add(current.value / 2);
            }
            if (!visited.Contains(current.value - 1))
            {
                queue.Enqueue((current.value - 1, current.step + 1));
                visited.Add(current.value);
            }
        }
   }
}