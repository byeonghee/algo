public static class BJ1620
{
    public static void Solution()
    {
        System.IO.StreamReader sr = new System.IO.StreamReader(Console.OpenStandardInput());
        System.IO.StreamWriter sw = new System.IO.StreamWriter(Console.OpenStandardOutput());
        System.Text.StringBuilder sb = new System.Text.StringBuilder();

        int[] inputs = Array.ConvertAll(sr.ReadLine().Split(' '), int.Parse);
        int N = inputs[0]; // 도감에 수록되어 있는 포켓몬의 개수
        int M = inputs[1]; // 문제의 개수

        Dictionary<int, string> dic = new Dictionary<int, string>();
        Dictionary<string, int> dic2 = new Dictionary<string, int>();

        for (int i = 1; i < N + 1; i++)
        {
            string input = sr.ReadLine();

            dic.Add(i, input);
            dic2.Add(input, i);
        }

        var keys = new List<int>(dic.Keys);

        for (int i = 0; i < M; i++)
        {
            string input = sr.ReadLine();
            int numInput;
            bool isNum = int.TryParse(input, out numInput);

            if (isNum)
            {
                sb.AppendLine(dic[numInput]);
            }
            else
            {
                sb.AppendLine(dic2[input].ToString());
            }
        }
        sw.Write(sb.ToString());

        sr.Close();
        sw.Flush();
        sw.Close();
    }
}