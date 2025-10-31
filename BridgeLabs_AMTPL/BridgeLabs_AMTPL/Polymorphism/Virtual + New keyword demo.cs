using System;
class Grandparent
{
    public virtual void Method()
    {
        Console.WriteLine("Grandpa method is being Used");
    }
}

class Parent : Grandparent
{
    public new virtual void Method()
    {
        Console.WriteLine("Parent method is being Used");
    }
}

class GrandChild : Parent
{
    public override void Method()
    {
        Console.WriteLine("GrandChild is being Used");
    }
}

class Program8
{
    public static void Main()
    {
        Grandparent gp = new Parent();
        gp.Method();
        Grandparent gp1 = new GrandChild();
        gp1.Method();
    }
}