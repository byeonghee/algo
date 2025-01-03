using System.Reflection;

public class MyCustomer
{
    private string name;
    private int age;

    public event EventHandler NameChanged;
    public MyCustomer(string name, int age)
    {
        this.name = name;
        this.age = age;
    }

    public string Name
    {
        get
        {
            return this.name;
        }
        set
        {
            if (this.name != value)
            {
                this.name = value;
                if (NameChanged != null)
                {
                    NameChanged(this, EventArgs.Empty);
                }
            }
        }
    }

    public int Age
    {
        get; set;
    }
    public string GetGetCustomerData()
    {
        string data = string.Format("Name: {0} (Age: {1})",
                    this.Name, this.Age);
        return data;
    }

    public void doEvent()
    {
        NameChanged.Invoke(this, EventArgs.Empty);
    }
}

public static class testClass
{
    public static void Solution()
    {
        MyCustomer lim = new MyCustomer("lim", 30);
        lim.NameChanged += new EventHandler(NameChanged);
        lim.doEvent();
        Console.WriteLine(lim.GetGetCustomerData());
    }

    public static void NameChanged(object sender, EventArgs e)
    {
        Console.WriteLine(sender);
    }
}