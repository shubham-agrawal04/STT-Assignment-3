using System;

class Student
{
    // Properties
    public string Name { get; set; }
    public int ID { get; set; }
    public double Marks { get; set; }

    // Constructor
    public Student(string name, int id, double marks)
    {
        Name = name;
        ID = id;
        Marks = marks;
    }

    // Method to get grade based on marks
    public string GetGrade()
    {
        if (Marks >= 90) return "A";
        else if (Marks >= 80) return "B";
        else if (Marks >= 70) return "C";
        else if (Marks >= 60) return "D";
        else return "F";
    }

    // Method to display student details
    public void Main()
    {
        Console.WriteLine("\nStudent Details:");
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"ID: {ID}");
        Console.WriteLine($"Marks: {Marks}");
        Console.WriteLine($"Grade: {GetGrade()}");
    }
}


class StudentIITGN : Student
{
    // New property for IITGN students
    public string Hostel_Name_IITGN { get; set; }

    // Constructor for IITGN students
    public StudentIITGN(string name, int id, double marks, string hostelName)
        : base(name, id, marks)
    {
        Hostel_Name_IITGN = hostelName;
    }

    // Method to display IITGN student details
    public void Main()
    {
        base.Main();
        Console.WriteLine($"Hostel: {Hostel_Name_IITGN}");
    }
}
