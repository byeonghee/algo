public class ModeAlgorithm{
    public static void Solution(){
        int[] scores = { 1, 3, 4, 3, 5 };

        int maxValue = scores.Max();

        int[] items = new int[maxValue + 1];

        int max = int.MinValue;
        int mode = 0;

        for (int i = 0; i < scores.Length; i++){
            items[scores[i]]++;
        } 
        for (int i = 0; i < items.Length; i++){
            if(items[i] > max){
                max = items[i];
                mode = i;
            }
        }

        Console.WriteLine($"최빈값(문) : {mode} -> {max}번 나타남");

        var q = scores.GroupBy(v => v).OrderByDescending(g => g.Count()).First();
        int modeCount = q.Count();
        int frequency = q.Key;
        Console.WriteLine($"최빈값(식) : {frequency} -> {modeCount}번 나타남");
    }
}