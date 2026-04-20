using System;

// S - Single Responsibility Principle
class StudentService
{
    public int GetStudentId()
    {
        return 310;
    }
}

class StudentDisplay
{
    public void DisplayStudent(string name)
    {
        Console.WriteLine("Student Name: " + name);
    }
}

// O - Open/Closed Principle

abstract class Discount
{
    public abstract double Calculate(double amount);
}

class RegularDiscount : Discount
{
    public override double Calculate(double amount)
    {
        return amount * 0.10; // 10% discount
    }
}

class StudentDiscount : Discount
{
    public override double Calculate(double amount)
    {
        return amount * 0.25; // 25% discount
    }
}

// L - Liskov Substitution Principle

abstract class Bird
{
    public abstract void Eat();
}

abstract class FlyingBird : Bird
{
    public abstract void Fly();
}

class Sparrow : FlyingBird
{
    public override void Eat()
    {
        Console.WriteLine("Sparrow eats.");
    }

    public override void Fly()
    {
        Console.WriteLine("Sparrow flies.");
    }
}

class Ostrich : Bird
{
    public override void Eat()
    {
        Console.WriteLine("Ostrich eats.");
    }
}

// I — Interface Segregation Principle
interface IWork
{
    void Work();
}

interface IEat
{
    void Eat();
}

class Human : IWork, IEat
{
    public void Work()
    {
        Console.WriteLine("Human Working");
    }

    public void Eat()
    {
        Console.WriteLine("Human Eating");
    }
}

class Robot : IWork
{
    public void Work()
    {
        Console.WriteLine("Robot Working");
    }
}

// D — Dependency Inversion Principle

interface IDatabase
{
    void Save();
}

class MySQLDatabase : IDatabase
{
    public void Save()
    {
        Console.WriteLine("Data saved in MySQL");
    }
}

class MongoDatabase : IDatabase
{
    public void Save()
    {
        Console.WriteLine("Data saved in MongoDB");
    }
}

class Application
{
    private IDatabase database;

    public Application(IDatabase db)
    {
        database = db;
    }

    public void SaveData()
    {
        database.Save();
    }
}

// Main Program

class Program
{
    public static void Main(string[] args)
    {
        // SRP
        Console.WriteLine("Single Responsibility Principle.");
        StudentDisplay display = new StudentDisplay();
        display.DisplayStudent("Atharv");

        StudentService service = new StudentService();
        int id = service.GetStudentId();
        Console.WriteLine("Id = " + id);

        Console.WriteLine();

        // OCP
        Console.WriteLine("Open/Closed Principle.");
        Discount studentDiscount = new StudentDiscount();
        Console.WriteLine("Student Discount: " + studentDiscount.Calculate(20000));

        Discount regularDiscount = new RegularDiscount();
        Console.WriteLine("Regular Discount: " + regularDiscount.Calculate(20000));

        Console.WriteLine();

        // LSP
        Console.WriteLine("Liskov Substitution Principle.");
        Sparrow sparrow = new Sparrow();
        sparrow.Eat();
        sparrow.Fly();

        Ostrich ostrich = new Ostrich();
        ostrich.Eat();

        Console.WriteLine();

        // ISP
        Console.WriteLine("Interface Segregation Principle.");
        Human human = new Human();
        human.Work();
        human.Eat();

        Console.WriteLine();

        // Robot can only Work
        Robot robot = new Robot();
        robot.Work();

        Console.WriteLine();

        // DIP
        Console.WriteLine("Dependency Inversion Principle.");
        IDatabase mySql = new MySQLDatabase();
        Application app1 = new Application(mySql);
        app1.SaveData();

        Console.WriteLine();

        // Switching to MongoDB
        IDatabase mongo = new MongoDatabase();
        Application app2 = new Application(mongo);
        app2.SaveData();

    }
}