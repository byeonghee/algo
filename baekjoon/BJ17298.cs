public class BJ17298{
    public static void Solution(){
        System.IO.StreamReader sr = new System.IO.StreamReader("q/BJ17298.txt");
        // System.IO.StreamReader sr = new System.IO.StreamReader(Console.OpenStandardInput());
        System.IO.StreamWriter sw = new System.IO.StreamWriter(Console.OpenStandardOutput());
        
        int inputCount = int.Parse(sr.ReadLine());

        int[] inputs = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);

        int[] answer = Enumerable.Repeat(-1, inputCount).ToArray();

        int totalMax = inputs[inputCount - 1];
        int max = inputs[inputCount - 1];

        System.Collections.Generic.Stack<int> stack = new System.Collections.Generic.Stack<int>();
        stack.Push(0);

        // 3 5 2 7
        // 1 2 3 4
        for (int i = 0; i < inputs.Length; i++) {
            while(stack.Count > 0 && inputs[i] > inputs[stack.Peek()]) {
                answer[stack.Pop()] = inputs[i];
            }
            stack.Push(i);
        }
        sw.WriteLine(string.Join(" ", answer));
        sw.Close();
    }
}