using System.Diagnostics;

public class ProcessDemo{
    public static void Solution(){
        Console.WriteLine(Environment.SystemDirectory);
        Console.WriteLine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments));

        Environment.Exit(0);
        
        // Process.Start("Notepad.exe");

        // Process.Start("Explorer.exe", "https://dotnetkorea.com");
    }
}