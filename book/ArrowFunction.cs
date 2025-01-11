using System.Globalization;

public static class ArrowFunction{
    public static void Solution(){
        Hi();
        Multiply(3, 5);

    }

    private static void Multiply(int v1, int v2) => Console.WriteLine(v1 * v2);

    private static void Hi() => Console.WriteLine("안녕");
}