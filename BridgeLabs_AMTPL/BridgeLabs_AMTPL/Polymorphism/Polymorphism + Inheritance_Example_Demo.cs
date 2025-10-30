using System;

class Animal3
{
    public virtual void Moves()
    {
        Console.WriteLine("Animal is Moving");
    }
}

class Bird : Animal3
{
    public override void Moves()
    {
        Console.WriteLine("Bird is Flying");
    }
}

class Fish : Animal3
{
    public override void Moves()
    {
        Console.WriteLine("Fish is Swimming");
    }
}

class Human : Animal3
{
    public override void Moves()
    {
        Console.WriteLine("Human is Walking/Running");
    }
}

class Program3
{
    static void Main()
    {
        Animal3 MyAnimal = new Animal3(); //Animal Reference Animal Object;
        MyAnimal.Moves();

        Animal3 MyBird = new Bird(); //Parent Reference, Subclass Object;
        MyBird.Moves();

        Animal3 MyFish = new Fish(); //Animal Reference, Fish Object;
        MyFish.Moves();

        Animal3 MyHuman = new Human(); //Animal Reference, Human Object;
        MyHuman.Moves();

        // This shows us Polymorphism, i.e., the program knows which Method to
        // execute Automatically by itself;
    }
}