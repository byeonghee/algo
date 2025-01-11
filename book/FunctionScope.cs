
public static class FunctionScope{
    static string message = "전역";
    public static void Solution(){
        ShowMessage();
        Console.WriteLine(message);
    }

    private static void ShowMessage()
    {
        string message = "지역";
        Console.WriteLine(message);
    }
}