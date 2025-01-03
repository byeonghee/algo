public static class testLCMandGCD
{
    public static void Solution()
    {

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
        return (a * b) / GCD(a, b);
    }
}