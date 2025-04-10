using System;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("\n==== CS202 STT-CSE Lab 10 ====");
            Console.WriteLine("1. Basic Program");
            Console.WriteLine("2. Control Structures");
            Console.WriteLine("3. Loops and Functions");
            Console.WriteLine("4. Object-Oriented Programming");
            Console.WriteLine("5. Exception Handling");
            Console.WriteLine("6. Exit");
            Console.Write("Enter choice: ");

            if (!int.TryParse(Console.ReadLine(), out int choice))
            {
                Console.WriteLine("Invalid input. Please enter a number.");
                continue;
            }

            switch (choice)
            {
                case 1:
                    Console.WriteLine("Welcome to Basic Program");
                    Welcome.Run();
                    break;
                case 2:
                    Console.Write("Welcome To Control Structures - Calculator [Without Try/catch] \n");
                    // Get user input
                    Console.Write("Enter first number: ");
                    double num1 = Convert.ToDouble(Console.ReadLine());

                    Console.Write("Enter second number: ");
                    double num2 = Convert.ToDouble(Console.ReadLine());

                    // Create Calculator object
                    Calculator calc = new Calculator(num1, num2);

                    // Display results
                    calc.DisplayResults();
                    break;
                case 3:
                    Console.WriteLine("Welcome to Loops and Functions");
                    bool running = true;
                    while (running)
                    {
                        Console.WriteLine("\nChoose an operation:");
                        Console.WriteLine("1. Print numbers from 1 to 10 (for loop)");
                        Console.WriteLine("2. Keep asking for input (while loop)");
                        Console.WriteLine("3. Calculate factorial");
                        Console.WriteLine("4. Exit");
                        Console.Write("Enter your choice: ");

                        if (!int.TryParse(Console.ReadLine(), out int choice2))
                        {
                            Console.WriteLine("Invalid input. Please enter a number.");
                            continue;
                        }

                        switch (choice2)
                        {
                            case 1:
                                LoopFunctions.PrintNumbers();
                                break;
                            case 2:
                                LoopFunctions.InputLoop();
                                break;
                            case 3:
                                Console.Write("Enter a number to calculate its factorial: ");
                                int num = Convert.ToInt32(Console.ReadLine());
                                long factorial = LoopFunctions.CalculateFactorial(num);
                                if (factorial != -1)
                                {
                                    Console.WriteLine($"Factorial of {num} is: {factorial}");
                                }
                                break;
                            case 4:
                                Console.WriteLine("Exiting Loops and Functions");
                                running = false;
                                break;
                            default:
                                Console.WriteLine("Invalid choice. Please select again.");
                                break;
                        }
                    }
                    break;
                case 4:
                    Console.WriteLine("Welcome to OOPS - Student Information System");
                    Console.WriteLine($"A student: ");
                    Student student = new Student("PRandal", 102, 89.90);
                    student.Main();
                    Console.WriteLine($"\nA student from IITGN: ");
                    StudentIITGN studentIITGN = new StudentIITGN("Shubhamm", 404, 91.6, "Emiet Hostel");
                    studentIITGN.Main();
                    break;
                case 5:
                    Console.Write("Welcome To Error Handling - Calculator [With Try/catch] \n");
                    
                    // Get user input safely
                    double number1 = Calculator2.GetValidNumber("Enter first number: ");
                    double number2 = Calculator2.GetValidNumber("Enter second number: ");

                    // Create Calculator object
                    Calculator2 calc2 = new Calculator2(number1, number2);

                    // Display results
                    calc2.DisplayResults();
                    break;
                case 6:
                    Console.WriteLine("Exiting...");
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please select again.");
                    break;
            }
        }
    }
}