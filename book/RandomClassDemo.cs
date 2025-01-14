public class RandomClassDemo{
    public static void Solution(){
        Random random = new Random();
        int lottoLength = 6;

        int[] list = new int[lottoLength];
        int temp = 0;

        for(int i = 0; i < lottoLength; i++){
            temp = random.Next(45) + 1;

            bool flag = false;

            Array.Find(list, n => n == temp ? (flag = true) : (flag = false));

            if (flag) i--;
            else list[i] = temp;
        }
        Array.Sort(list);
        Console.WriteLine(string.Join(", ", list));
    }
}