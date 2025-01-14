public class IsAs{
    
    public static void Solution(){
        IsWhat(1234);

        object x = 1234;
        if (x is int)
        {
            int i = (int)x;
            Console.WriteLine($"{x}는 정수형으로 변환이 가능합니다. {i}");

        }

        Console.WriteLine(x is int);

        object s = "안녕하세요.";

        if (s is string) //특정 형식인지 비교
        {
            string? sValue = s as string; 

            Console.WriteLine($"[1] {s}는 null이 아니며 문자열 형식으로 변환이 가능합니다. {sValue}");
        }

        PrintStars(5);
        PrintStars(null);
    }

    static void PrintStars(object o){
        if (o is null){
            return;
        }
        if (o is string){
            return;
        }

        if(!(o is int number)){
            return;
        }

        Console.WriteLine(new string('*', number));
    }

    static void IsWhat(object o){
        if (o is int){
            Console.WriteLine("Int");
        } else if (o is string){
            Console.WriteLine("string");
        } else if (o is DateTime){
            Console.WriteLine("DateTime");
        }
    }
}