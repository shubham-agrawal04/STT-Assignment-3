using System;

class LoopFunctions
{
    // Function to print numbers from 1 to 10 using a for loop
    public static void PrintNumbers()
    {
        Console.WriteLine("Numbers from 1 to 10:");
        for (int i = 1; i <= 10; i++)
        {
            Console.Write(i + " ");
        }
        Console.WriteLine();
    }

    // Function to ask user for input using a while loop until they enter "exit"
    public static void InputLoop()
    {
        string input;
        while (true)
        {
            Console.Write("Enter something (type 'exit' to stop): ");
            input = Console.ReadLine();
            if (input.ToLower() == "exit")
            {
                Console.WriteLine("Exiting input loop...");
                break;
            }
        }
    }

    // Function to calculate factorial of a number
    public static long CalculateFactorial(int num)
    {
        if (num < 0)
        {
            Console.WriteLine("Factorial is not defined for negative numbers.");
            return -1;
        }

        long fact = 1;
        for (int i = 1; i <= num; i++)
        {
            fact *= i;
        }
        return fact;
    }

    // Function to execute all methods
    public static void ExecuteLoopsAndFunctions()
    {
        PrintNumbers();  // Call the for loop function

        Console.Write("Enter a number to calculate its factorial: ");
        int num = Convert.ToInt32(Console.ReadLine());
        long factorial = CalculateFactorial(num);
        if (factorial != -1)
        {
            Console.WriteLine($"Factorial of {num} is: {factorial}");
        }

        InputLoop();  // Call the while loop function
    }
}
