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
        Animal3 MyAnimal = new Animal3();
        MyAnimal.Moves();

        Animal3 MyBird = new Bird();
        MyBird.Moves();

        Animal3 MyFish = new Fish();
        MyFish.Moves();

        Animal3 MyHuman = new Human();
        MyHuman.Moves();
    }
}