public class EnumAnimal{
    enum Animal { Mouse, Cow, Tiger, Rabbit = 5, Monkey, 말 }

    public static void Solution(){
        Animal animal = Animal.Tiger;

        int num = (int)animal;

        Console.WriteLine(animal);

        if (animal == Animal.Tiger){
            Console.WriteLine($"{num} : 호랑이, {(int)Animal.Monkey} : {Animal.Monkey}, {(int)Animal.말} :  {Animal.말}" );
        }

        switch (animal)
        {
            case Animal.Mouse:
                Console.WriteLine("쥐쥐");
                break;
            case Animal.Cow:
                Console.WriteLine("소소");
                break;
            case Animal.Tiger:
                Console.WriteLine("호랑이");
                break;
            default:
                Console.WriteLine("기본값 설정 영역");
                break;
        }

    }
}