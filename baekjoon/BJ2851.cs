using System.Windows.Markup;

public static class BJ2851
{
    public static void Solution()
    {
        int current = 0;
        int[] inputs = new int[10];
        for (int i = 0; i < 10; i++)
        {
            inputs[i] = int.Parse(Console.ReadLine());
        }

        current += inputs[0];
        for (int i = 1; i < inputs.Length; i++)
        {
            int sum = current + inputs[i];

            if (100 < sum)
            {
                if (sum - 100 <= 100 - current)
                {
                    current = sum;
                }
                break;
            }
            else
            {
                current += inputs[i];
            }
        }

        Console.WriteLine(current);
    }
}