using System.ComponentModel.DataAnnotations;

public class BJ1932
{
    public static void Solution()
    {
        //System.IO.StreamReader sr = new("q/BJ1932.txt");
        System.IO.StreamReader sr = new(Console.OpenStandardInput());

        int inputCount = int.Parse(sr.ReadLine());
        System.Collections.Generic.List<Tuple<int, string>> items = new System.Collections.Generic.List<Tuple<int, string>>();
        for (int i = 0; i < inputCount; i++)
        {
            string value = sr.ReadLine();
            if (items.Count > 0)
            {
                int[] input = Array.ConvertAll(value.Split(' '), int.Parse);

                int[] item = Array.ConvertAll(items[i - 1].Item2.Split(','), int.Parse);

                for (int j = 0; j < input.Length; j++)
                {
                    if (j == 0)
                    {
                        input[0] = input[0] + item[0];
                    }
                    else if (j == input.Length - 1)
                    {
                        input[input.Length - 1] = input[j] + item[item.Length - 1];
                    }
                    else
                    {
                        input[j] = Math.Max(input[j] + item[j - 1], input[j] + item[j]);
                    }

                }
                items.Add(new Tuple<int, string>(i, string.Join(',', input)));
            }
            else
            {
                items.Add(new Tuple<int, string>(i, string.Join(',', value)));
            }
        }
        int[] result = Array.ConvertAll(items[inputCount - 1].Item2.Split(','), int.Parse);

        Array.Sort(result);

        Console.WriteLine(result[result.Length - 1].ToString());
    }
}