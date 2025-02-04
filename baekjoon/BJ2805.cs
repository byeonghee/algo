using System.Reflection.Metadata;

public class BJ2805 {
    public static void Solution(){
        System.IO.StreamReader sr = new System.IO.StreamReader("q/BJ2805.txt");
        // System.IO.StreamReader sr = new System.IO.StreamReader(Console.OpenStandardInput());

        int[] inputs = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);

        int N = inputs[0];
        int M = inputs[1];

        int[] items = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);

        int low = 0;
        int high = items.Max();

        while(low <= high){
            int mid = (high + low) / 2;

            long sum = 0;
            for(int i = 0; i < items.Length; i++){
                if(items[i] > mid){
                    sum += items[i] - mid;
                }
            }

            // 카운트 된 값이 더 작을 경우는 나무를 더짤라야해서 Max 를 줄여야함
            if(sum < M) {
                high = mid - 1;
            } else {
                low = mid + 1;
            }
        }

        Console.WriteLine(high);
    }
}