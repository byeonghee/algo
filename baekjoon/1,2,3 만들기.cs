public class BJ9095
{
    public static void Solution()
    {
        System.IO.StreamReader sr = new("q/1,2,3 만들기.txt");


        int inputCount = int.Parse(sr.ReadLine());


        int[] results = new int[10 +1];

        results[1] = 1;
        results[2] = 2;
        results[3] = 4;
        for (int i = 4; i < 11; i++)
        {
            results[i] = results[i - 1] + results[i - 2] + results[i - 3];

        }
        for (int i = 0; i < inputCount; i++)
        {
            Console.WriteLine(results[int.Parse(sr.ReadLine())]);
        }
    }
}