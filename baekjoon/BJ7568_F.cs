using System.Collections;

public static class BJ7568_F
{
    public static void Solution()
    {
        int inputCount = int.Parse(Console.ReadLine());
        int[,] inputs = new int[inputCount, 2];
        int[] rank = new int[inputCount];
        // List<int> height = new List<int>();
        for (int i = 0; i < inputCount; i++)
        {
            int[] input = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

            inputs[i, 0] = input[0];
            inputs[i, 1] = input[1];

            // weight.Add(input[0]);
            // height.Add(input[1]);
        }

        // // 1. 들어온 값중에 큰값에 높은 점수를 준다.
        // weight.Sort();
        // height.Sort();

        // // 2. 몸무게와 키를 점수에 넣는다.
        // int[] sortList = new int[inputCount];
        // List<int> sList = new List<int>();
        // for (int i = 0; i < inputCount; i++)
        // {
        //     int sum = weight.IndexOf(inputs[i, 0]) + height.IndexOf(inputs[i, 1]) + inputCount;
        //     sortList[i] = sum;
        //     if (!sList.Contains(sum))
        //     {
        //         sList.Add(sum);
        //     }
        // }
        // sList.Sort();

        // // 3. 1등일 경우는 1 동급일 경우는 같은 수 
        // int count = 1;
        // for (int i = sList.Count - 1; 0 < i; i--)
        // {
        //     int v = 0;
        //     for (int j = 0; j < sortList.Length; j++)
        //     {
        //         if (sortList[j] == sList[i])
        //         {
        //             sortList[j] = count;
        //             v++;
        //         }
        //     }
        //     count += v;
        // }

        for (int i = 0; i < inputCount; i++)
        {
            int count = 1;
            for (int j = 0; j < inputCount; j++)
            {
                if (i != j && inputs[i, 0] < inputs[j, 0] && inputs[i, 1] < inputs[j, 1])
                {
                    count++;
                }
            }
            rank[i] = count;
        }

        Console.WriteLine(string.Join(' ', rank));

    }
}