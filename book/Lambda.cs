public class Lambda{
    public static void Solution(){
        Func<int, bool> isEven = x => x % 2 == 0;

        Console.WriteLine(isEven(2));
        Console.WriteLine(isEven(3));

        Action<string> greet = name => { var message = $"Hello {name}"; Console.WriteLine(message); };

        greet("You");

        int[] numbers = { 1, 2, 3, 4, 5 };

        var even = numbers.Where(isEven).Sum();
        var whe = numbers.Where(number => number % 2 == 0).Sum();

        Console.WriteLine(whe);
        Console.WriteLine(even);


        var q = numbers.Where(n => n % 2 == 1);
        var nums = numbers.Where(it => it % 2 == 0 && it > 3);
        foreach (var n in q)
        {
            Console.WriteLine(n);
        }

        foreach (var n in nums)
        {
            Console.WriteLine(n);
        }

        bool[] blns = { true, false, true, false, true };

        Console.WriteLine(blns.Count());
        Console.WriteLine(blns.Count(bln => bln == true));
        Console.WriteLine(blns.Count(bln => bln == false));

        bool[] completes = { true, true, true };
        bool all = completes.All(c => c == true);
        bool any = completes.Any(c => c == false);

        Console.WriteLine(all);
        Console.WriteLine(any);

        int[] arr = { 1, 2, 3 };
        bool bln = arr.Any(num => num == 2); //bool 값 반환
        Console.WriteLine(bln);

        var data = Enumerable.Range(0, 100);

        var five = data.Take(5);
        var whereFive = data.Where(x => x % 2 == 0).Take(5);
        var next = data.Skip(10).Take(5);

        var query = (from n in data where n % 2 == 0 & n < 10 select n);

        foreach (var item in query){
            Console.WriteLine("query: {0}",item);
        }

        foreach (var n in five){
            Console.WriteLine(n);
        }
        foreach (var n in whereFive){
            Console.WriteLine(n);
        }
        foreach (var n in next){
            Console.WriteLine(n);
        }

        int[] arr2 = { 2, 2, 3, 3, 3 };

        arr2.Distinct();

        string[] colors = { "Red", "Green", "Blue" };

        IEnumerable<string> sortedColors = colors.OrderBy(name => name);

        foreach (var color in sortedColors){
            Console.WriteLine(color);
        }

        string red = colors.Single(c => c == "Red");
        // string black = colors.Single(c => c == "Black");
        string? black2 = colors.SingleOrDefault(c => c == "Black");
        Console.WriteLine(red);
        Console.WriteLine(black2);
        // Console.WriteLine(black);

        string firstRed = colors.First(c => c == "Red");



        int[] number = { 1, 2, 3, 4, 5 };
        var select = numbers.Select(it => it * 2);

        foreach(var num in select){
            Console.WriteLine("select: {0}",num);
        }

        var names = new List<string> { "sss", "asea", "wewe", };

        var nameObjects = names.Select(n => new { Name = n });

        foreach (var name in nameObjects){
            Console.WriteLine("name : {0}",name.Name);
        }

        (from n in data where n % 2 == 0 & n < 10 select n).ToList().ForEach(n => Console.WriteLine(n));
    }
}