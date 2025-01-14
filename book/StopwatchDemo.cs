using System.Diagnostics;

public class StopwatchDemo{
    public static void Solution(){
        Stopwatch timer = new Stopwatch();
        timer.Start();
        LongTimeProcess();
        timer.Stop();

        Console.WriteLine(timer.Elapsed.TotalMilliseconds);
        Console.WriteLine(timer.Elapsed.Seconds);   
    }

    static void LongTimeProcess(){
        Thread.Sleep(3000);
    }
}