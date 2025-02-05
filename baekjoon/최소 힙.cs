using System.Data;

public class BJ1927{
    public static void Solution() {
        System.IO.StreamReader sr = new System.IO.StreamReader("q/최소 힙.txt");
        // System.IO.StreamReader sr = new System.IO.StreamReader(Console.OpenStandardInput());
        System.IO.StreamWriter sw = new System.IO.StreamWriter(Console.OpenStandardOutput());
        System.Text.StringBuilder sb = new System.Text.StringBuilder();

        int inputCount = int.Parse(sr.ReadLine());

        PriorityQueue<int, int> queue = new PriorityQueue<int, int>(); 

        for (int i = 0; i < inputCount; i++) {
            int target = int.Parse(sr.ReadLine());

            if(target == 0) {
                sb.AppendLine(queue.Count > 0 ? queue.Dequeue().ToString() : "0");
            } else {
                queue.Enqueue(target, target);
            }
        }

        sw.Write(sb.ToString());
        sw.Close();
    }
}