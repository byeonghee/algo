public static class BJ1476
{
    public static void Solution()
    {
        int[] inputs = Array.ConvertAll(Console.ReadLine().Split(" "), int.Parse);

        // 지구를 나타내는 수 
        int E = inputs[0];
        // 태양을 나타내는 수
        int S = inputs[1];
        // 달을 나타내는 수
        int M = inputs[2];

        // 1 <= E <= 15
        // 1 <= S <= 28
        // 1 <= M <= 19

        // 모든 수를 돌리면서 E S M 값이 같을때까지 돌린다.

        int targetE = 0;
        int targetS = 0;
        int targetM = 0;

        int count = 0;

        while (true)
        {
            count++;
            targetE += 1;
            targetS += 1;
            targetM += 1;

            if (targetE == 16) targetE = 1;
            if (targetS == 29) targetS = 1;
            if (targetM == 20) targetM = 1;

            if (targetE == E && targetS == S && targetM == M) break;
        }

        Console.WriteLine(count);
    }
}