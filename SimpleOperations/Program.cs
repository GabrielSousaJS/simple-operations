using SimpleOperations;
using System.Diagnostics;

public class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("First operation");
        HelloUser.Hello();

        Console.WriteLine("Second operation");
        Concatenate.Concat();

        Console.WriteLine("Third operation");
        MathematicalOperation.Addition();
        MathematicalOperation.Subtraction();
        MathematicalOperation.Multiplication();
        MathematicalOperation.Division();
        MathematicalOperation.ArithmeticAverage();

        Console.WriteLine("Fourth operation");
        CharacterContactor.Count();

        Console.WriteLine("Fifth operation");
        string response = CheckCarLicensePlate.CheckPlate() == true ? "Verdadeiro" : "Falso";
        Console.WriteLine(response);

        Console.WriteLine("Sixth operation");
        CurrentDate.Date();
    }
}