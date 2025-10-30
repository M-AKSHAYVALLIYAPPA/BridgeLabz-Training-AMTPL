using System;

class Animal1
{
    public void Eat()
    {
        Console.WriteLine("Animal is Eating..");
    }
}

class Dog1 : Animal1
{
    public void Bark()
    {
        Console.WriteLine("Dog is Barking !");
    }
}

class Puppy : Dog1
{
    public void Play()
    {
        Console.WriteLine("Puppy is Playing !!");
    }
}

class Program1
{
    static void Main()
    {
        Puppy puppy = new Puppy();
        puppy.Eat();
        puppy.Bark();
        puppy.Play();
    }
}