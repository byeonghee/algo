using System.Globalization;
using System.Security.Cryptography;
using System.Text;

public class BJ1753
{
    public static void Solution()
    {
        System.IO.StreamReader sr = new("q/최단경로.txt");
        // System.IO.StreamReader sr = new(Console.OpenStandardInput());
        System.IO.StreamWriter sw = new(Console.OpenStandardOutput());


        string[] VE = sr.ReadLine().Split();

        int V = int.Parse(VE[0]); // 정점의 개수
        int E = int.Parse(VE[1]); // 간선의 개수

        int K = int.Parse(sr.ReadLine()); // 시작 정점


        string[] dist = Enumerable.Repeat("INF", V + 1).ToArray();

        

    




    }
}

public class BJ1753_V2
{
    class Edge
    {
        public int To{ get; }
        public int Weight{ get; }
        public Edge(int to, int weight)
        {
            To = to;
            Weight = weight;
        }
    }
    public static void Solution()
    {
        var sr = new System.IO.StreamReader("q/최단경로.txt");
        string[] input = sr.ReadLine().Split();
        int v = int.Parse(input[0]);
        int e = int.Parse(input[1]);

        List<List<Edge>> graph = new List<List<Edge>>();

        for (int i = 0; i <= v; i++)
        {
            graph.Add(new List<Edge>());
        }
        int startVertex = int.Parse(sr.ReadLine());

        for (int i = 0; i < e; i++)
        {
            input = sr.ReadLine().Split();
            int from = int.Parse(input[0]);
            int to = int.Parse(input[1]);
            int weight = int.Parse(input[2]);

            graph[from].Add(new Edge(to, weight));
        }

        int[] distance = new int[v + 1];
        Array.Fill(distance, Int32.MaxValue);

        distance[startVertex] = 0;

        bool[] visited = new bool[v + 1];

        for (int i = 0; i < v - 1; i++)
        {
            int minDistance = int.MaxValue;
            int currentVertex = 0;

            for (int j = 1; j <= v; j++)
            {
                if (!visited[j] && distance[j] < minDistance)
                {
                    minDistance = distance[j];
                    currentVertex = j;
                }
            }
            visited[currentVertex] = true;
            foreach (Edge edge in graph[currentVertex])
            {
                if (!visited[edge.To] && distance[currentVertex] != int.MaxValue)
                {
                    int newDistance = distance[currentVertex] + edge.Weight;

                    if (newDistance < distance[edge.To])
                    {
                        distance[edge.To] = newDistance;
                    }
                }
            }
        }

        System.Text.StringBuilder sb = new ();

        for (int i = 1; i <= v; i++)
        {
            if (distance[i] == Int32.MaxValue)
            {
                sb.AppendLine("INF");
            }
            else
            {
                sb.AppendLine(distance[i].ToString());
            }
        }

        Console.WriteLine(sb.ToString()); 
    }
}