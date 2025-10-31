using System;

class Base
{
    public virtual void Test()
    {
        Console.WriteLine("Base Test");
    }
}

class Derived : Base
{
    public new void Test()
    {
        Console.WriteLine("Derived Test");
    }
}

class Program7
{
    static void Main()
    {
        Base obj = new Derived();
        obj.Test();
        Derived obj1 = new Derived();
        obj1.Test();

    }
}