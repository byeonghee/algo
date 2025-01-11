public class DelegateDemo
{
    public static void Solution()
    {


    }
    delegate int MyDelegate(int x, int y);

    public static void CalcDelegate()
    {

        MyDelegate del = new MyDelegate(Add);

        Console.WriteLine(del(1, 2));

        Console.WriteLine(Calc(Add));

        Console.WriteLine(OtherCalc(1, 2, Minus));


        MyDelegate[] myDelegates = { Add, Minus };

        myDelegates[0](1, 2);
        static int Calc(MyDelegate myDelegate)
        {
            return myDelegate(1, 2);
        }

        static int OtherCalc(int x, int y, MyDelegate myDelegate)
        {
            return myDelegate(x, y);
        }

        static int Add(int x, int y)
        {
            return x + y;
        }

        static int Minus(int x, int y)
        {
            return x - y;
        }
        static int Pow(int x)
        {
            return x * x;
        }
    }
}

public class Archive
{
    public delegate void CompProg(int x);

    public static void Compress(int nFile, CompProg Prog)
    {
        for (int i = 0; i < nFile; i++)
        {
            Prog(i);
            System.Threading.Thread.Sleep(500);
        }
    }
}

public static class DelegateTest
{
    public static void Progress(int nFile)
    {
        Console.WriteLine("{0}번째 파일을 압축하는 중입니다.", nFile + 1);
    }

    public static void EngProgress(int nFile)
    {
        Console.WriteLine("Now Compressing {0} File. Wait Please", nFile + 1);
    }

    public static void Solution()
    {
        Archive.Compress(10, EngProgress);
        Console.WriteLine("모든 파일을 압축하였습니다.");
    }
}

public class MyEventArea
{
    public delegate void MyEventDelegate();
    public event MyEventDelegate myEvent;

    public void StartInvoke()
    {
        myEvent.Invoke();
    }
}

public static class MyEventDel
{
    public static void Solution()
    {
        MyEventArea myEventArea = new MyEventArea();
        myEventArea.myEvent += test1;
        myEventArea.myEvent += test2;
        myEventArea.myEvent += test3;

        myEventArea.StartInvoke();
    }

    public static void test1()
    {
        Console.WriteLine("Test1");
    }
    public static void test2()
    {
        Console.WriteLine("Test2");
    }
    public static void test3()
    {
        Console.WriteLine("Test3");
    }
}

public class MyArea
{
    public delegate void MyDelegate();

    public MyDelegate myDelegate;
}

public static class MyDel
{
    public static void Solution()
    {
        MyArea myArea = new MyArea();

        myArea.myDelegate += test1;
        myArea.myDelegate += test2;
        myArea.myDelegate += test3;

        myArea.myDelegate.Invoke();
    }

    public static void test1()
    {
        Console.WriteLine("Test1");
    }
    public static void test2()
    {
        Console.WriteLine("Test2");
    }
    public static void test3()
    {
        Console.WriteLine("Test3");
    }
}

class Field
{
    static int classVar = 10;
    int instanceVar = 20;

    int Method()
    {
        int localVar = 30;

        return localVar;
    }
}