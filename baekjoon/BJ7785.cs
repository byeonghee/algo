using System.Text;

public static class BJ7785
{
    public static void Solution()
    {
        System.IO.StreamReader sr = new System.IO.StreamReader(Console.OpenStandardInput());
        System.IO.StreamWriter sw = new System.IO.StreamWriter(Console.OpenStandardOutput());

        int inputCount = int.Parse(sr.ReadLine());
        List<string> list = new List<string>();
        Dictionary<string, int> dic = new Dictionary<string, int>();

        for (int i = 0; i < inputCount; i++)
        {
            string person = sr.ReadLine().Split(' ')[0];
            if (dic.ContainsKey(person))
            {
                dic.Remove(person);
            }
            else
            {
                dic.Add(person, 1);
            }
        }
        var dicOrder = dic.OrderByDescending(c => c.Key);

        foreach (var item in dicOrder)
        {
            sw.WriteLine(item.Key);
        }

        sr.Close();
        sw.Flush();
        sw.Close();
    }
}

