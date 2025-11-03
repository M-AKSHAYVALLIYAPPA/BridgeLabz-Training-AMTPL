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
        Grandparent gp = new Parent();  //If new is used, the object will definetly point to Parent Class reference only
        gp.Method();
        Grandparent gp1 = new GrandChild(); //Same policy, Since new is used in Parent class, It will point towards it's own Parent, i.e., Grandparent method
        gp1.Method();
    }
}