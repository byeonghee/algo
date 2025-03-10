
public class BJ11726
{
    public static void Solution()
    {
        int input = int.Parse(Console.ReadLine());
        int[] items = new int[1001];
        items[1] = 1;
        items[2] = 2;
        items[3] = 3;
        for (int i = 4; i < input + 1; i++)
        {
            items[i] = (items[i - 1] + items[i - 2]) % 10007;
        }
        Console.WriteLine(items[input]);
    }
}