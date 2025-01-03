using System.Security.Cryptography.X509Certificates;

public static class BJ1934
{
    public static void Solution()
    {
        int inputCount = int.Parse(Console.ReadLine());
        int[,] inputs = new int[inputCount, 2];
        for (int i = 0; i < inputCount; i++)
        {
            int[] input = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

            inputs[i, 0] = input[0];
            inputs[i, 1] = input[1];
        }

        for (int i = 0; i < inputCount; i++)
        {
            // Console.WriteLine(LCM(inputs[i, 0], inputs[i, 1]));
            int a = inputs[i, 0];
            int b = inputs[i, 1];
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }

            Console.WriteLine((inputs[i, 0] * inputs[i, 1]) / a);
        }
    }

    public static int GCD(int a, int b)
    {
        // if (b == 0) return a;

        // return GCD(b, a % b);
        while (b != 0)
        {
            int temp = b;
            b = a % b;
            a = temp;
        }

        return a;
    }

    public static int LCM(int a, int b)
    {
        int gcd = GCD(a, b);
        int ilcm = (a * b) / gcd;
        return (ilcm);
    }
}