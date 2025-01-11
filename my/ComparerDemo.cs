public class ComparerDemo
{
    public static void Solution()
    {
        int[] intValues = { 3, 2, 4, 1, 6, 7, 5 };

        Array.Sort(intValues, new IntComparer());

        Console.WriteLine(string.Join(' ', intValues));


        Person jack = new Person("jack", 10);
        Person john = new Person("john", 8);
        Person tom = new Person("tom", 11);

        Person[] people = { jack, john, tom };

        Array.Sort(people);

        foreach (Person p in people)
        {
            Console.WriteLine("{0} {1}", p._name, p._age);
        }
    }
}

public class Person : IComparable<Person>
{
    public string _name;
    public int _age;
    public Person(string name, int age)
    {
        _name = name;
        _age = age;
    }

    public int CompareTo(Person? other)
    {
        return _age - other._age;
    }
}

public class IntComparer : IComparer<int>
{
    public int Compare(int x, int y)
    {
        return y - x;
    }
}