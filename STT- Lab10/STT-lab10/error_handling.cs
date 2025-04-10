using System;

class Calculator2
{
    // Properties to store numbers
    public double Num1 { get; set; }
    public double Num2 { get; set; }

    // Constructor to initialize numbers
    public Calculator2(double num1, double num2)
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
        try
        {
            if (Num2 == 0)
                throw new DivideByZeroException("Error: Division by zero is not allowed!");

            return Num1 / Num2;
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine(ex.Message);
            return double.NaN; // Return Not a Number
        }
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
        if (!double.IsNaN(divisionResult)) // Check if division was valid
            Console.WriteLine($"Division: {divisionResult}");

        // Check if the sum is even or odd
        CheckEvenOdd();
    }

    // Static method for safe user input
    public static double GetValidNumber(string prompt)
    {
        double number;
        while (true)
        {
            Console.Write(prompt);
            string input = Console.ReadLine();
            if (double.TryParse(input, out number))
                return number;

            Console.WriteLine("Invalid input! Please enter a valid number.");
        }
    }
}
