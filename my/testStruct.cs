public static class testStruct
{
    class MyClassPoint
    {
        public int X;
        public int Y;

        public MyClassPoint(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }
        public override string ToString()
        {
            return string.Format("({0}, {1})", X, Y);
        }
    }
    struct MyStructPoint
    {
        public int X;
        public int Y;

        public MyStructPoint(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        public override string ToString()
        {
            return string.Format("({0}, {1})", X, Y);
        }
    }
    public static void Solution()
    {
        MyStructPoint point = new MyStructPoint(11, 12);
        Console.WriteLine(point.ToString());
        Console.WriteLine(typeof(MyStructPoint));

        MyClassPoint classPoint = new MyClassPoint(11, 12);
        Console.WriteLine(classPoint.ToString());
        Console.WriteLine(typeof(MyClassPoint));
    }
}