using System;

class Animal5
{
    public string name = "Animal";
    protected string species = "Unknown";
    internal int age = 5;
    private double weight = 20.5;

    public void DisplayInfo()
    {
        Console.WriteLine("Name: " + name);
        Console.WriteLine("Species: " + species);
        Console.WriteLine("Age: " + age);
        Console.WriteLine("Weight: " + weight);
    }
}

class Dog5 : Animal5
{
    public void DisplayDogInfo()
    {
        Console.WriteLine("Dog's Name: " + name);
        Console.WriteLine("Dog's Species: " + species);
        Console.WriteLine("Dog's Age: " + age);
        //Console.WriteLine("Dog's Weight: " + weight);
    }
}

class Program5
{
    static void Main()
    {
        Animal5 animal = new Animal5();
        animal.DisplayInfo();
        Dog5 dog = new Dog5();
        dog.DisplayDogInfo();
    }
}
