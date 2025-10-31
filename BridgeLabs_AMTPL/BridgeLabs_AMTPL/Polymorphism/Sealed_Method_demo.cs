using System;
class A
{
    public virtual void Method()
    {
        Console.WriteLine("A is being used");
    }
}
class B : A
{
    public sealed override void Method()
    {
        Console.WriteLine("B is being Used !! //eg., Sealed overrride method");
    }
}

/* COMPILE ERROR! , Sealed overide methods can't be overridden again!!
class C : B
{
    public override void Method()
    {
        Console.WriteLine("C is being Used !!");
    }
}
*/
class Program9
{
    public static void Main()
    {
        A obj = new B();
        obj.Method();
    }
}