public class BJ1655
{
    public static void Solution()
    {
        System.IO.StreamReader sr = new System.IO.StreamReader("q/가운데를 말해요.txt");
        // System.IO.StreamReader sr = new System.IO.StreamReader(Console.OpenStandardInput());
        System.IO.StreamWriter sw = new System.IO.StreamWriter(Console.OpenStandardOutput());
        System.Text.StringBuilder sb = new System.Text.StringBuilder();

        PriorityQueue<int, int> min = new(), max = new();
        
        int count = int.Parse(sr.ReadLine());
        int mid = int.MinValue;

        for (int i = 0; i < count; i++)
        {
            int target = int.Parse(sr.ReadLine());

            if (mid == int.MinValue) mid = target;
            else if (min.Count >= max.Count)
            {
                int minValue = Math.Min(mid, target);
                int inputItem = Math.Max(mid, target);

                max.Enqueue(inputItem, inputItem);

                mid = min.EnqueueDequeue(minValue, minValue * -1);
            }
            else
            {
                int maxValue = Math.Max(mid, target);
                int inputItem = Math.Min(mid, target);

                min.Enqueue(inputItem, inputItem * -1);

                mid = max.EnqueueDequeue(maxValue, maxValue);
            }


            sb.AppendLine(mid.ToString());
        }

        sw.Write(sb.ToString());
        sw.Close();
    }
}