using System.Runtime.CompilerServices;

enum Priority{
    High,
    Normal,
    Low
}

enum Align
{
    Top = 0,
    Bottom = 2,
    Left = 4,
    Right = 8
}
public class EnumerationDemo{
    public static void Solution(){
        Priority high = Priority.High;
        Priority normal = Priority.Normal;
        Priority low = Priority.Low;

        Console.WriteLine($"{high}, {normal}, {low}");

        
        Type cc = typeof(ConsoleColor);
        string[] colors = Enum.GetNames(cc);

        foreach(var color in colors){
            Console.WriteLine(color);
        }

        string customColor = "Red";

        Console.ForegroundColor = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), customColor);
        Console.WriteLine(customColor);
        Console.ResetColor();
    }
}