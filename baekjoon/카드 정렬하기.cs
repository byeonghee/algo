public class BJ1715
{
    public static void Solution()
    {
        System.IO.StreamReader sr = new System.IO.StreamReader("q/카드 정렬하기.txt");
        // System.IO.StreamReader sr = new System.IO.StreamReader(Console.OpenStandardInput());


        PriorityQueue<int, int> queue = new PriorityQueue<int, int>();

        int inputCount = int.Parse(sr.ReadLine());
        int answer = 0;

        for (int i = 0; i < inputCount; i++)
        {
            int target = int.Parse(sr.ReadLine());

            queue.Enqueue(target, target);
        }

        if (queue.Count >= 2)
        {
            for (int i = 1; i < inputCount; i++)
            {
                int targetA = queue.Dequeue();
                int targetB = queue.Dequeue();

                answer += (targetA + targetB);

                queue.Enqueue((targetA + targetB), (targetA + targetB));
            }
        }

        Console.WriteLine(answer);
    }
}