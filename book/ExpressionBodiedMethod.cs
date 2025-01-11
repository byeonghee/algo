
public static class ExpressionBodiedMethod{
    public static void Solution(){
        Log("함수 축약");
        Console.WriteLine(IsSame("A", "B"));
    }

    private static void Log(string v) => Console.WriteLine(v);

    private static bool IsSame(string v1, string v2) => v1 == v2;
}