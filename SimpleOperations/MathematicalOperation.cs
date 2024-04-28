namespace SimpleOperations;

public class MathematicalOperation
{
    public static void Addition()
    {
        double x = double.Parse(Console.ReadLine());
        double y = double.Parse(Console.ReadLine());

        Console.WriteLine($"Addition: {x + y}");
    }

    public static void Subtraction()
    {
        double x = double.Parse(Console.ReadLine());
        double y = double.Parse(Console.ReadLine());

        Console.WriteLine($"Subtraction: {x - y}");
    }

    public static void Multiplication()
    {
        double x = double.Parse(Console.ReadLine());
        double y = double.Parse(Console.ReadLine());

        Console.WriteLine($"Multiplication: {x * y}");
    }

    public static void Division()
    {
        double x = double.Parse(Console.ReadLine());
        double y = double.Parse(Console.ReadLine());

        if (y == 0)
            Console.WriteLine("Cannot divide by zero!");
        else
            Console.WriteLine($"Division: {x / y}");

    }

    public static void ArithmeticAverage()
    {
        double x = double.Parse(Console.ReadLine());
        double y = double.Parse(Console.ReadLine());

        Console.WriteLine($"Arithmetic average: {(x + y) / 2}");
    }
}
