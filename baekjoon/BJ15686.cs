using System.Globalization;

public class BJ15686{
    public static void Solution(){
        System.IO.StreamReader sr = new System.IO.StreamReader("q/BJ15686.txt");
        System.IO.StreamWriter sw = new System.IO.StreamWriter(Console.OpenStandardOutput());

        int[] nm = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);

        int N = nm[0];
        int M = nm[1];

        int[,] graph = new int[N, N];
        List<Tuple<int,int>> chicken = new List<Tuple<int,int>>();
        List<Tuple<int, int>> house = new List<Tuple<int,int>>();

        for(int i = 0; i < N; i++){
            int[] h = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);

            for(int j = 0; j < N; j++){
                if(h[j] == 1) {
                    house.Add(new Tuple<int, int>(i, j));
                } else if (h[j] == 2) {
                    chicken.Add(new Tuple<int, int>(i, j));
                }

            }
        }

        //|r1-r2| + |c1-c2|
        dfs(0, []);
        int[] answers = new int[M * M];
        // 모든 치킨집을 돌아봐야함
        void dfs(int count, List<Tuple<int, int>> list){

            if(count == M) {
                
            }

        }
    }


}