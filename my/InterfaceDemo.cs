public class InterfaceDemo
{
    public static void Solution()
    {
        IAnimal cat = new Cat();
        cat.bark();

        IAnimal dog = new Dog();
        dog.bark();

        Dog dog1 = new Dog();
        dog1.aa();
    }
}

public interface IAnimal
{
    void move();
    void bark(); // 짖다...
}

public class Cat : IAnimal
{
    public void move()
    {
        Console.WriteLine("Cat Moved");
    }

    public void bark()
    {
        Console.WriteLine("Cat bark");
    }
}

public class Dog : IAnimal
{
    public void bark()
    {
        Console.WriteLine("Dog Moved");
    }

    public void move()
    {
        Console.WriteLine("Dog bark");
    }

    public void aa()
    {
        Console.WriteLine("aa");
    }
}

public interface IExample
{
    void DoSomething();

    static void Doing()
    {
        Console.WriteLine("123");
    }
}

public abstract class Example : IExample
{
    public abstract void DoSomething();

    public virtual void Doit()
    {
        Console.WriteLine("Doit is virtual method Doit Called Example abstract class");
    }

}

public class ConcreateExample : Example
{
    public override void DoSomething()
    {
        Console.WriteLine("ConcreateExample called DoSometing!");
    }

    public override void Doit()
    {
        base.Doit();
    }
}

public class ConCreate
{
    public override string ToString()
    {
        return base.ToString();
    }
}

public class ExplicitImpliment
{
    public interface IControl
    {
        void Solution();

    }

    public interface ISurface
    {
        void Solution();
    }

    public class SampleClass : IControl, ISurface
    {
        public void Solution()
        { // 암묵적 구현
            Console.WriteLine("Solution Method in SampleClass");
        }

        void IControl.Solution()
        { // 명시적 구현
            Console.WriteLine("IControl Solution");
        }

        void ISurface.Solution()
        { // 명시적 구현
            Console.WriteLine("ISurface Solution");
        }
    }

}

public static class Sample
{
    public static void Solution()
    {
        ExplicitImpliment.SampleClass sam = new ExplicitImpliment.SampleClass();

        sam.Solution();

        ExplicitImpliment.IControl control = new ExplicitImpliment.SampleClass();

        control.Solution();

        ExplicitImpliment.ISurface surface = new ExplicitImpliment.SampleClass();
        surface.Solution();

    }
}

public interface IUnit
{
    void Attack();
}

public class Unit : IUnit
{
    public virtual void Attack()
    {
        Console.WriteLine("기본공격!");
    }

    public void Move()
    {
        Console.WriteLine("무브무브");
    }
}

public class Marine : Unit
{
    public override void Attack()
    {
        Console.WriteLine("탕탕탕");
    }
    public void StimPack()
    {
        Console.WriteLine("푸푸푸");
    }
}

public static class StarCreaft
{
    public static void Solution()
    {
        Marine marine = new Marine();
        marine.Attack();

        IUnit unit = new Marine();

        unit.Attack();
    }
}