enum eEnum{
    item1,
    item2
}

class Foo {
    public eEnum type;
    public int subtype;

    public override bool Equals(object? obj)
    {
        return obj is Foo foo && type == foo.type && subtype == foo.subtype;
    }

    public override int GetHashCode(){
        return HashCode.Combine(type, subtype);
    }
}


public class EqualsAndHashCodeDemo{
    public static void Solution(){
        Dictionary<Foo, int> pairs = new Dictionary<Foo, int>();

        pairs.Add(new Foo() { type = eEnum.item1, subtype = 2 }, 1);

        var target = new Foo() { type = eEnum.item1, subtype = 2 };

        if(pairs.ContainsKey(target)){
            Console.WriteLine("match");
        }  else {
            Console.WriteLine("not match");
        }
    }
}