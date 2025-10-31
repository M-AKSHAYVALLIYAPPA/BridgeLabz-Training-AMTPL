using System;

class Animal2
{
    public virtual void Sound() //always use virtual method for overriding
    {
        Console.WriteLine("Animal makes a Sound");
    }
}

class Dog2 : Animal2
{
    public override void Sound()
    {
        Console.WriteLine("Dog is Barking !");
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
        Animal2 animal = new Animal2(); //Animal Object Created
        animal.Sound(); //Animal Sound method is now called 

        Dog2 dog = new Dog2(); //Dog object is created
        dog.Sound(); //Overrided Sound Method from Animal called from Dog Class

        Cat2 cat = new Cat2(); //Dog object is created
        cat.Sound(); //Overrided Sound Method from Animal called from Cat Class
    }
}