public class BJ11866 {
    // class Node {
    //     public Node? next;
    //     public int value;
    //     public Node(int _value){
    //         this.value = _value;
    //         this.next = null;
    //     }
    //     public void SetNext(Node _node) {
    //         next = _node;
    //     }
    // }

    public static void Solution() {
        System.IO.StreamReader sr = new System.IO.StreamReader("q/요세푸스 문제0.txt");
        // System.IO.StreamReader sr = new System.IO.StreamReader(Console.OpenStandardInput());

        int[] nk = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);

        int n = nk[0]; // 원을 이루면서 앉아있는 사람의 수
        int k = nk[1]; // k 번째 사람을 제거

        List<int> answer = new List<int>();

        // LinkedList<int> list = new LinkedList<int>();
        LinkedList<int> list = new LinkedList<int>();

        for (int i = 1; i <= n; i++) {
            list.AddLast(i);
        }

        int pointer = 1;

        while(list.Count > 0) {
            if(pointer % k == 0) {
                answer.Add(list.First());
            }else {
                list.AddLast(list.First());
            }
            list.RemoveFirst();

            pointer++;

        }

        Console.WriteLine($"<{string.Join(", ", answer)}>");
    }

    // public static void Solution2() {
    //     System.IO.StreamReader sr = new System.IO.StreamReader("q/요세푸스 문제0.txt");

    //     int[] nk = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);

    //     int n = nk[0]; // 원을 이루면서 앉아있는 사람의 수
    //     int k = nk[1]; // k 번째 사람을 제거

    //     Node root = new Node(1);
    //     Node iter = root;
    //     for (int i = 2; i <= n; i++)
    //     {
    //         iter.SetNext(new Node(i));
    //         iter = iter.next;
    //     }
    //     iter.next = root;  // 원형 리스트로 연결
    // }
}