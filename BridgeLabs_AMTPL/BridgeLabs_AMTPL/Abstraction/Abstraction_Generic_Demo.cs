/*
 ABSTRACTION ? : hides Implementation details, Expose only essesntial features
                 Focuses on what an Object does rather than How?
                 Creates a framework for other classes to build upon? What is Framework?
                 Used for Maintainability & Scalability

How do you Implement ABSTRACTION? : 2 ways, Abstract Class (Can achieve 0-100%), Interfaces (Full 100% Abstraction)

You cannot create objects in Abstract class directly
abstract methods == No body, Non-abstract methods can have a body
*/

abstract class Vehicle
{
    // Fields (instance variables) ✅Implementable
    protected string _brand;
    private int _year;

    // Constants ✅
    public const int MaxSpeed = 200;

    // Constructor ✅
    public Vehicle(string brand, int year)
    {
        _brand = brand;
        _year = year;
        Console.WriteLine("Vehicle constructor called");
    }
    // Concrete method with implementation ✅
    public string GetInfo()
    {
        return $"This is a {_brand} vehicle from {_year}";
    }

    // Virtual method (can be overridden) ✅
    public virtual void StartEngine()
    {
        Console.WriteLine($"{_brand} engine is starting...");
    }

    // Abstract method (must be implemented by derived classes) ❌Not Implementable
    public abstract void Move();
    // Abstract property (must be implemented) ❌
    public abstract int CurrentSpeed { get; set; }
    // Concrete property ✅
    public int Year
    {
        get { return _year; }
        set { _year = value; }
    }
}
class Car : Vehicle
{
    private int _speed;
    public Car(string brand, int year) : base(brand, year) { }
    // Implementation of abstract method
    public override void Move()      
    {
        Console.WriteLine($"{_brand} car is driving on the road");
    }
    // Implementation of abstract property
    public override int CurrentSpeed
    {
        get { return _speed; }
        set { _speed = value; }
    }
    // Override virtual method
    public override void StartEngine()
    {
        base.StartEngine(); // Call base implementation
        Console.WriteLine("Car engine started!");
    }
}
// Usage
public class Program10
{
    public static void Main()
    {
        Car car = new Car("Toyota", 2024);
        car.StartEngine();
        car.Move();
        car.CurrentSpeed = 60;
    }
}
