public class Counter{
    public void GetTodayVisitCount(){
        Console.WriteLine("1234");
    }
}

public class ObjectNote{
    public static void Solution(){
        Counter counter= new Counter();
        counter.GetTodayVisitCount();
    }
}