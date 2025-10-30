using System;

class Animal2
{
    public virtual void Sound()
    {
        Console.WriteLine("Animal makes a Sound");
    }
}

class Dog2 : Animal2
{
    public override void Sound()
    {
        Console.WriteLine("Dog is Barking");
    }
}

class Cat2 : Animal2
{
    public override void Sound()
    {
        Console.WriteLine("Cat is Meowing");
    }
}

class Program2
{
    static void Main()
    {
        Animal2 animal = new Animal2();
        animal.Sound();

        Dog2 dog = new Dog2();
        dog.Sound();

        Cat2 cat = new Cat2();
        cat.Sound();
    }
}