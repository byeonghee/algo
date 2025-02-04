public class BJ11286 {
    public static void Solution() {
        // 배열에 0이 아닌 정수를 넣는다.
        // 배열에서 절대값이 가작 작은 값을 출력하고 그 값은 배열에서 제거한다. 
        

        // 첫째줄엔 연산의 개수
        // 연산에 대한 정수 x 
        // X 가 0 이 아니라면 배열에 X 값을 넣고 0 이라면 배열에서 절댓값이 가장 작은 값을 출력하고 배열에서 제거

        // 절대값은 작은데 음수가 먼저 출력

        // 배열이 비어있는 경우는 0 출력

        System.IO.StreamReader sr = new System.IO.StreamReader("q/절댓값 힙.txt");
        //System.IO.StreamReader sr = new System.IO.StreamReader(Console.OpenStandardInput());
        System.IO.StreamWriter sw = new System.IO.StreamWriter(Console.OpenStandardOutput());
        System.Text.StringBuilder sb = new System.Text.StringBuilder();

        int count = int.Parse(sr.ReadLine());

        // List<int> plus = new List<int>();
        // List<int> minus = new List<int>();

        PriorityQueue<int,int> plus = new PriorityQueue<int, int>();
        PriorityQueue<int, int> minus = new PriorityQueue<int, int>();

        for(int i = 0; i < count; i++) {
            int x = int.Parse(sr.ReadLine());

            if (x == 0) {
                if (plus.Count > 0 || minus.Count > 0)
                {
                    if (plus.Count > 0 && minus.Count == 0)
                    {
                        sb.AppendLine(plus.Dequeue().ToString());
                    }
                    else if (minus.Count > 0 && plus.Count == 0)
                    {
                        sb.AppendLine("-" + minus.Dequeue().ToString());
                    } 
                    else if (plus.Peek() < minus.Peek())
                    {
                        sb.AppendLine(plus.Dequeue().ToString());
                    }
                    else
                    {
                        sb.AppendLine("-" + minus.Dequeue().ToString());
                    }
                } else {
                    sb.AppendLine(0.ToString());
                }
            } else {
                if(x > 0) {
                    plus.Enqueue(x,Math.Abs(x));
                } else {
                    minus.Enqueue(Math.Abs(x),Math.Abs(x));
                }
            }
        }

        sw.Write(sb.ToString());
        sw.Close();
    }
}