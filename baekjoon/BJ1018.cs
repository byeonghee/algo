// using System.ComponentModel;

// public static class BJ1018
// {
//     public static void Solution()
//     {
//         var input = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
//         int N = input[0];
//         int M = input[1];

//         string[,] items = new string[M, N];

//         for (int i = 0; i < N; i++)
//         {
//             string[] item = Console.ReadLine().Split(' ');

//             for (int j = 0; j < item.Length; j++)
//             {
//                 items[i, j] = item[j];
//             }
//         }

//         int mValue = M - 8;
//         int nValue = N - 8;
//         int total = 0;
//         while (true)
//         {
//             string target = "B";
//             for (int k = 0; k < 2; k++)
//             {
//                 int count = 0;

//                 if (k == 1)
//                 {
//                     target = "W";
//                 }
//                 for (int i = nValue; 0 <= i; i--)
//                 {
//                     for (int j = mValue; 0 <= j; j--)
//                     {
//                         if ((j + i) % 2 != 0 && target == "B" && items[j, i] == "W")
//                         {
//                             count++;
//                         }
//                     }
//                 }
//                 if (count < total)
//                 {
//                     total = count;
//                 }
//             }

//             if (mValue == 0 && nValue == 0)
//             {
//                 break;
//             }
//         }
//         Console.WriteLine(total);
//     }
// }


using System.ComponentModel;

public static class BJ1018
{
    public static void Solution()
    {
        var input = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
        int N = input[0];
        int M = input[1];
        int result = 0;
        int result2 = 0;

        List<int> values = new List<int>();

        string[,] items = new string[N, M];


        for (int i = 0; i < N; i++)
        {
            char[] item = Console.ReadLine().ToCharArray();

            for (int j = 0; j < item.Length; j++)
            {
                items[i, j] = item[j].ToString();
            }
        }


        int nValue = 0;
        int mValue = 0;
        while (true)
        {
            for (int i = nValue; i < 8 + nValue; i++)
            {
                for (int j = mValue; j < 8 + mValue; j++)
                {
                    if ((i + j) % 2 == 0 && items[i, j] == "B")
                    {
                        result++;
                    }
                    if ((i + j) % 2 == 0 && items[i, j] == "W")
                    {
                        result2++;
                    }

                    if ((i + j) % 2 != 0 && items[i, j] == "W")
                    {
                        result++;
                    }
                    if ((i + j) % 2 != 0 && items[i, j] == "B")
                    {
                        result2++;
                    }
                }
            }
            values.Add(result);
            values.Add(result2);
            result = 0;
            result2 = 0;

            if (N - 8 == nValue && M - 8 == mValue)
            {
                break;
            }

            if (N - 8 == nValue)
            {
                nValue = 0;
                mValue++;
            }
            else
            {
                nValue++;
            }
        }

        Console.WriteLine(values.Min());
    }
}