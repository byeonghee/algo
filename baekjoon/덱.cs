public class BJ10866{
    public static void Solution() {
        System.IO.StreamReader sr = new System.IO.StreamReader("q/덱.txt");
        // System.IO.StreamReader sr = new System.IO.StreamReader(Console.OpenStandardInput());
        System.IO.StreamWriter sw = new System.IO.StreamWriter(Console.OpenStandardOutput());
        System.Text.StringBuilder sb = new System.Text.StringBuilder();

        int inputCount = int.Parse(sr.ReadLine());

        LinkedList<int> inputList = new LinkedList<int>();
        List<int> answer = new List<int>();

        for (int i = 0; i < inputCount; i++) {
            string[] input = sr.ReadLine().Split();

            switch (input[0]) {
                case "push_front":
                    inputList.AddFirst(int.Parse(input[1]));
                    break;
                case "push_back":
                    inputList.AddLast(int.Parse(input[1]));
                    break;
                case "pop_front":
                    if(inputList.Count > 0) {
                        sb.AppendLine(inputList.First().ToString());
                        inputList.RemoveFirst();
                    } else {
                        sb.AppendLine("-1");
                    }
                    break;
                case "pop_back":
                    if(inputList.Count > 0) {
                        sb.AppendLine(inputList.Last().ToString());
                        inputList.RemoveLast();
                    } else {
                        sb.AppendLine("-1");
                    }
                    break;
                case "size":
                    sb.AppendLine(inputList.Count.ToString());
                    break;
                case "empty":
                    if (inputList.Count > 0)
                    {
                        sb.AppendLine("0");
                    } else {
                        sb.AppendLine("1");
                    }
                    break;
                case "front":
                    if (inputList.Count > 0)
                    {
                        sb.AppendLine(inputList.First().ToString());
                    } else {
                        sb.AppendLine("-1");
                    }
                    break;
                case "back":
                    if (inputList.Count > 0)
                    {
                        sb.AppendLine(inputList.Last().ToString());
                    } else {
                        sb.AppendLine("-1");
                    }
                    break;
                default:
                    break;
            }
        }

        sw.WriteLine(sb.ToString());
        sw.Close();
    }
}