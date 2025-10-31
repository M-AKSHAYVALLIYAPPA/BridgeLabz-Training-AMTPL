using System;
class D
{
    public virtual void Method()
    {
        Console.WriteLine("D Method is being used");
    }
}

class E : D
{
    public new void Method()
    {
        Console.WriteLine("E Method is being Used");
    }
}

/* It is not possible to override "new" Method
class F : E
{
    public override void Method()
    {
        Console.WriteLine("F Method is being Used");
    }
}
*/