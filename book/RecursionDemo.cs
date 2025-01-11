
public static class RecusionDemo{
    public static void Solution(){
        Console.WriteLine(4 * 3 * 2 * 1);
        Console.WriteLine(FactorialFor(4));
        Console.WriteLine(Factorial(4));
        Console.WriteLine(Fact(4));
    }

    private static int Fact(int v)
    {
        return (v > 1) ? v * Fact(v - 1) : 1;
    }

    private static int Factorial(int v)
    {
        if(v == 0 || v == 1){
            return 1;
        }

        return v * Factorial(v - 1);
    }

    private static int FactorialFor(int v)
    {
        int result = 1;
        for(int i = 1; i <= v; i++){
            result *= i;
        }
        return result;
    }
}