using System;
/*
//1


// Define the IVehicle interface
public interface IVehicle
{
    void StartEngine();
    void StopEngine();
}

// Implement the IVehicle interface in the Car class
public class Car : IVehicle
{
    public void StartEngine()
    {
        Console.WriteLine("Car engine started.");
    }

    public void StopEngine()
    {
        Console.WriteLine("Car engine stopped.");
    }
}

// Implement the IVehicle interface in the Bike class
public class Bike : IVehicle
{
    public void StartEngine()
    {
        Console.WriteLine("Bike engine started.");
    }

    public void StopEngine()
    {
        Console.WriteLine("Bike engine stopped.");
    }
}

// Demonstrate the design
public class Program
{
    public static void Main(string[] args)
    {
        IVehicle myCar = new Car();
        IVehicle myBike = new Bike();

        myCar.StartEngine();
        myCar.StopEngine();

        myBike.StartEngine();
        myBike.StopEngine();
    }
}

//2

// Abstract class Shape
public abstract class Shape
{
    public abstract double GetArea(); // Abstract method
    public void Display() // Non-abstract method
    {
        Console.WriteLine($"The area is: {GetArea()}");
    }
}

// Rectangle class implementing Shape
public class Rectangle : Shape
{
    public double Width { get; set; }
    public double Height { get; set; }

    public Rectangle(double width, double height)
    {
        Width = width;
        Height = height;
    }

    public override double GetArea()
    {
        return Width * Height;
    }
}

// Circle class implementing Shape
public class Circle : Shape
{
    public double Radius { get; set; }

    public Circle(double radius)
    {
        Radius = radius;
    }

    public override double GetArea()
    {
        return Math.PI * Radius * Radius;
    }
}

// Demonstrate the design
public class Program
{
    public static void Main(string[] args)
    {
        Shape rectangle = new Rectangle(5, 10);
        rectangle.Display();

        Shape circle = new Circle(7);
        circle.Display();
    }
}
//3

// Product class implementing IComparable
public class Product : IComparable<Product>
{
    public int Id { get; set; }
    public string Name { get; set; }
    public double Price { get; set; }

    public Product(int id, string name, double price)
    {
        Id = id;
        Name = name;
        Price = price;
    }

    public int CompareTo(Product other)
    {
        return Price.CompareTo(other.Price); 
    }

    public override string ToString()
    {
        return $"Id: {Id}, Name: {Name}, Price: {Price}";
    }
}

// Demonstrate sorting
public class Program
{
    public static void Main(string[] args)
    {
        Product[] products = {
            new Product(1, "Laptop", 1000),
            new Product(2, "Phone", 500),
            new Product(3, "Tablet", 750)
        };

        Array.Sort(products);

        foreach (var product in products)
        {
            Console.WriteLine(product);
        }
    }
}
//4

public class Student
{
    public int Id { get; set; }
    public string Name { get; set; }
    public double Grade { get; set; }

    public Student(Student other)
    {
        Id = other.Id;
        Name = string.Copy(other.Name);
        Grade = other.Grade;
    }

    public override string ToString()
    {
        return $"Id: {Id}, Name: {Name}, Grade: {Grade}";
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Student student1 = new Student { Id = 1, Name = "John", Grade = 90 };
        Student student2 = new Student(student1); // Deep copy

        student1.Name = "Mike"; // Change name in student1

        // Display both objects
        Console.WriteLine($"Student 1: {student1}");
        Console.WriteLine($"Student 2: {student2}");
    }
}
//5

public interface IWalkable
{
    void Walk();
}

public class Robot : IWalkable
{
    public void Walk()
    {
        Console.WriteLine("Robot is walking with wheels.");
    }

    // Explicit interface implementation
    void IWalkable.Walk()
    {
        Console.WriteLine("Robot walking via IWalkable interface.");
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Robot robot = new Robot();

        // Calling the interface method explicitly
        ((IWalkable)robot).Walk();

        // Calling the class method
        robot.Walk();
    }
}
//6

public struct Account
{
    private int AccountId;
    private string AccountHolder;
    private double Balance;

    public Account(int accountId, string accountHolder, double balance)
    {
        AccountId = accountId;
        AccountHolder = accountHolder;
        Balance = balance;
    }

    public int GetAccountId() => AccountId;
    public string GetAccountHolder() => AccountHolder;
    public double GetBalance() => Balance;

    public void DisplayAccountInfo()
    {
        Console.WriteLine($"AccountId: {AccountId}, AccountHolder: {AccountHolder}, Balance: {Balance}");
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Account account = new Account(101, "Ahmed", 1500.50);
        account.DisplayAccountInfo();
    }
}
//7

public interface ILogger
{
    void Log()
    {
        Console.WriteLine("Logging message from default implementation.");
    }
}

public class ConsoleLogger : ILogger
{
    public void Log()
    {
        Console.WriteLine("Logging message from ConsoleLogger implementation.");
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        ILogger logger = new ConsoleLogger();
        logger.Log(); 
    }
}
*/

