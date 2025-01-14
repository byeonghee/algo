public class LinqSum{
    public static void Solution(){
        int[] numbers = { 1, 2, 3, };

        int sum = numbers.Sum();
        int count = numbers.Count();
        double average = numbers.Average();
        int max = numbers.Max();
        int min = numbers.Min();

        Console.WriteLine($"{sum}, {count}, {average}, {max}, {min}");
    }
}