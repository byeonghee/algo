// 7
// 3 10
// 5 20
// 1 10
// 1 20
// 2 15
// 4 40
// 2 200

// 0 0 15 35 45 45 45
// 


// 45

using System.Globalization;

public static class BJ14501_F
{
    public static void Solution()
    {
        int input = int.Parse(Console.ReadLine());

        int[] time = new int[input];
        int[] pay = new int[input];
        int[] dp = new int[input + 1];
        for (int i = 0; i < input; i++)
        {
            int[] item = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

            time[i] = item[0];
            pay[i] = item[1];
        }

        // N 번째 날에 일한 금액이 더 적다면 Max 값 변경
        // 2일 이라면 2일에 벌수 있는 최대 금액을 작성하는데 

        // for (int i = input - 1; 0 < i; i--)
        // {
        //     if (time[i] + i > input)
        //     {
        //         dp[i] = dp[i + 1];
        //     }
        //     else
        //     {
        //         int[] item = new int[2];
        //         item[0] = dp[i + 1] + pay[i];
        //         item[1] = dp[i + 1];

        //         dp[i] = item.Max();
        //     }
        // }

        // N일차는 N일차의 최대 값을 구한다.
        // dp 에 날짜를 더한날과 dp + 1 의 Max 값을 구한다.

        for (int i = input - 1; 0 <= i; i--)
        {
            if (input < time[i] + i)
            {
                dp[i] = dp[i + 1];
            }
            else
            {
                dp[i] = int.Max(pay[i] + dp[i + time[i]], dp[i + 1]);
            }
        }


        Console.WriteLine(dp[0]);


    }
}