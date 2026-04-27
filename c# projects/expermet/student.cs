using System;

class Student
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
    public string Course { get; set; }

    public Student(int id, string name, int age, string course)
    {
        Id = id;
        Name = name;
        Age = age;
        Course = course;
    }

    public void Display()
    {
        Console.WriteLine($"ID: {Id}, Name: {Name}, Age: {Age}, Course: {Course}");
    }
}