public class BJ1987{
    static int R, C;
    static int[] visited;
    static int[,] graph;
    static int[,] iGraph;
    static int[] dx = { 0, 1, 0 , -1};
    static int[] dy = { -1, 0, 1, 0 };
    static int answer = 1;

    public static void Solution(){
        // System.IO.StreamReader sr = new System.IO.StreamReader("q/BJ1987.txt");
        System.IO.StreamReader sr = new System.IO.StreamReader(Console.OpenStandardInput());

        System.IO.StreamWriter sw = new System.IO.StreamWriter(Console.OpenStandardOutput());

        int[] inputs = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);

        R = inputs[0];
        C = inputs[1];
        int alphabetCount = 'Z' - 'A' + 1;
        int max = 0;

        visited = new int[alphabetCount];

        graph = new int[R, C];
        iGraph = new int[R, C];

        for (int i = 0; i < R; i++) {
            char[] item = sr.ReadLine().ToCharArray();
            for (int j = 0; j < C; j++) {
                graph[i, j] = item[j] - 'A';
            }
        }
        iGraph[0, 0] = 1;

        dfs(0, 0);

        Console.WriteLine(answer);

        sw.Close();

    }

    static void dfs(int x, int y) {
        visited[graph[x, y]] = 1;
        // graph[x, y] = 0;

        for(int i =0; i < 4; i++){
            int newX = x + dx[i];
            int newY = y + dy[i];


            if((newX == 0 && newY == 0) || newX < 0 || newY < 0 || R <= newX || C <= newY || visited[graph[newX, newY]] == 1) {
                continue;
            }
            iGraph[newX, newY] = iGraph[x, y] + 1;

            if (iGraph[newX, newY] > answer){
                answer = iGraph[newX, newY];
            }

            dfs(newX, newY);

            visited[graph[newX, newY]] = 0;
        }
    }
}