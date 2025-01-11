struct BusinessCard{
    public string Name;
    public int Age;
}
public static class StructArray{
    
    static void Print(string name, int age) => Console.WriteLine($"{name} {age}");
    public static void Solution(){
        BusinessCard card;

        card.Name = "";
        card.Age = 111;
        Print(card.Name, card.Age);

        BusinessCard[] names  = new BusinessCard[2];
        names[0].Name = "이세영"; names[0].Age = 102;
        names[1].Name = "권경민"; names[1].Age = 31;
        for (int i = 0; i < names.Length; i++)
        {
            Print(names[i].Name, names[i].Age);
        }

    }
}


struct Member

{
    public string Name;
    public int Age;
}
class StructParameter
{
    static void Solution()
    {
        string name = "백승수";
        int age = 21;
        Print(name, age);

        Member m;
        m.Name = "이세영";
        m.Age = 100;
        Print(m);
    }

    static void Print(string name, int age) =>
        Console.WriteLine($"이름 : {name}, 나이 : {age}");

    static void Print(Member member) =>
        Console.WriteLine($"이름 : {member.Name}, 나이 : {member.Age}");
}