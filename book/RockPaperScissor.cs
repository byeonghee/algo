

public class RockPaperScissor{
    public static void Solution(){
        int iRandom = 0;
        int iSelection = 3;
        string[] choice = { "가위", "바위", "보" };

        while(true) {

            Console.Write("1(가위), 2(바위), 3(보) 입력 : _\b");

            iRandom = new Random().Next(1, 4);
            iSelection = Convert.ToInt32(Console.ReadLine());

            if(iSelection == 0) { break; }
            if (iSelection > 3) { Console.WriteLine("가위, 바위, 보 로 입력해주세요."); continue; }

            Console.WriteLine("\n 사용자 : {0}", choice[iSelection - 1]);
            Console.WriteLine(" 컴퓨터 : {0}\n", choice[iRandom - 1]);

            if (iSelection == iRandom)
            {
                Console.WriteLine("비김");
            }
            else
            {
                switch (iSelection)
                {
                    case 1: Console.WriteLine((iRandom == 3) ? "승" : "패"); break;
                    case 2: Console.WriteLine((iRandom == 1) ? "승" : "패"); break;
                    case 3: Console.WriteLine((iRandom == 2) ? "승" : "패"); break;
                }
            }
        }

    }
}