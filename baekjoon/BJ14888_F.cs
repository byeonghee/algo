public static class BJ14888_F
{
    public static void Solution()
    {
        int numCount = int.Parse(Console.ReadLine());
        LinkedList<int> nums = new LinkedList<int>(Array.ConvertAll(Console.ReadLine().Split(), int.Parse));
        int[] targets = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);


        int plus = targets[0];
        int minus = targets[1];
        int multiply = targets[2];
        int divide = targets[3];


    }

    public static void max(LinkedList<int> nums, int result)
    {
        if (nums.Count == 0)
        {
            Console.WriteLine(result);
            return;
        }


    }
}