
public static class RecursionPower{
    public static void Solution(){
        Console.WriteLine(MyPower(2, 5));
    }

    private static int MyPower(int num, int cnt)
    {
        if (cnt == 0){
            return 1;
        }
        return num * MyPower(num, --cnt);
    }
}