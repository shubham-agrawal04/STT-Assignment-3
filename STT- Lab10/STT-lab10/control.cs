using System;

class Calculator
{
    // Properties to store numbers
    public double Num1 { get; set; }
    public double Num2 { get; set; }

    // Constructor to initialize numbers
    public Calculator(double num1, double num2)
    {
        Num1 = num1;
        Num2 = num2;
    }

    // Methods for arithmetic operations
    public double Add() => Num1 + Num2;
    public double Subtract() => Num1 - Num2;
    public double Multiply() => Num1 * Num2;

    public double Divide()
    {
        if (Num2 == 0)
        {
            //Console.WriteLine("Error: Division by zero is not allowed!");
            return double.NaN; // Return Not a Number
        }
        return Num1 / Num2;
    }

    // Method to check if sum is even or odd
    public void CheckEvenOdd()
    {
        double sum = Add();
        if (sum % 2 == 0)
            Console.WriteLine($"Sum ({sum}) is Even.");
        else
            Console.WriteLine($"Sum ({sum}) is Odd.");
    }

    // Method to display results
    public void DisplayResults()
    {
        Console.WriteLine($"Addition: {Add()}");
        Console.WriteLine($"Subtraction: {Subtract()}");
        Console.WriteLine($"Multiplication: {Multiply()}");
        double divisionResult = Divide();
        Console.WriteLine($"Division: {divisionResult}");

        // Check if the sum is even or odd
        CheckEvenOdd();
    }
}