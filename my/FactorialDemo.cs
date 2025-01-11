using System.Security.Cryptography.X509Certificates;

public class FactorialDemo
{
    public static void Solution()
    {
        Console.WriteLine(Factorial(10));
    }

    public static int Factorial(int n)
    {
        if (n < 1)
        {
            return 1;
        }

        return n * Factorial(n - 1);
    }
}