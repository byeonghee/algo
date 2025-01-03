public static class BJ2346_F
{
    public static void Solution()
    {
        int inputCount = int.Parse(Console.ReadLine());

        List<int> inputs = new List<int>(Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse));

        int[] result = new int[inputCount];

        int currentIndex = 0; // result 가 바라보고 있는 현재 인덱스 값
        int target = 0; // 터트릴 풍선의 위치
        int index = 1; // result 인덱스에 넣을 값
        int count = 0; // count 와 같다면 target 이 같다면 해당 result 에 값을 넣는다.

        bool isMinus = false;

        while (true)
        {
            // 변경한 값이 들어온값과 같다면 반복을 멈춘다.
            if (index == inputCount)
            {
                break;
            }

            // currentIndex 가 범위를 벗어났을때 교정
            if (currentIndex > inputCount - 1)
            {
                currentIndex = currentIndex % inputCount;
            }
            else if (currentIndex < 0)
            {
                currentIndex = inputCount - 1;
            }

            // result[currentIndex] 가 0 이 아니라면 resultIndex 의 값을 올려준다.
            if (result[currentIndex] != 0)
            {
                if (isMinus)
                {
                    currentIndex--;
                    continue;
                }
                else
                {
                    currentIndex++;
                    continue;
                }
            }


            // 타겟만큼 돌면서 result 의 값이 0 일 경우에만 count 를 올려준다.
            if (target == count)
            {
                result[index] = index;
                index++;
                count = 0;
                target = inputs[currentIndex];

                if (target < 0)
                {
                    isMinus = true;
                }
                else
                {
                    isMinus = false;
                }
            }
            else // target 과 count 가 같지 않다면 currentIndex 와 count 값을 올려준다.
            {
                if (isMinus)
                {
                    count--;
                    currentIndex--;
                }
                else
                {
                    count++;
                    currentIndex++;
                }
            }
        }

        Console.WriteLine(string.Join(' ', result));
    }
}