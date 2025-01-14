public class SearchAlgorithm{
    public static void Solution(){
        int[] data = { 1, 3, 5, 7, 9 };

        int N = data.Length;

        int search = 3;
        bool flag = false;

        int index = -1;

        int low = 0;
        int high = N - 1;

        while(low <= high){
            int mid = (low + high) / 2;
            if(data[mid] == search) {
                flag = true;
                index = mid;
                break;
            }

            if(data[mid] > search){
                high = mid - 1;
            } else {
                low = mid + 1;
            }
        }

        if(flag){
            Console.WriteLine($"{index}");
        } else {
            Console.WriteLine("None");
        }

    }
}