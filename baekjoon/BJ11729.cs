public static class BJ11729
{
    // f(n) = 1 + 2f(n-1)

    public static void Solution()
    {
        int input = int.Parse(Console.ReadLine());

        Hanoi('1', '2', '3', input);

    }



    static void Hanoi(char from, char via, char to, int count)
    {
        if (count == 1)
        {
            Console.WriteLine("{0} {1}", from, to);

            return;
        }

        Hanoi(from, to, via, count - 1);
        Console.WriteLine("{0} {1}", from, to);
        Hanoi(via, from, to, count - 1);
    }
}