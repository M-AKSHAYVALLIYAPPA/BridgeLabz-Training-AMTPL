using System;

class Animal
{
    public void Eat()
    {
        Console.WriteLine("Animal is Eating");
    }
}

class Dog : Animal
{
    public void Bark()
    {
        Console.WriteLine("Dog is Barking");
    }
}

class Program
{
    static void Main()
    {
        Dog dog = new Dog();
        dog.Eat();
        dog.Bark();
    }
}