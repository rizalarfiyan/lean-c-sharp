class Program
{
    static void Main(string[] args)

    {
        Animal animal = new Animal();
        animal.Speak();

        Cat cat = new Cat();
        animal = cat;
        animal.Speak();
    //cat.Speak();

        Chicken chicken = new Chicken();
        //chicken.Speak();
        animal = chicken;
        animal.Speak();

        Dog dog = new Dog();
        //dog.Speak();
        animal = dog;
        animal.Speak();

        Console.ReadKey();
    }
}