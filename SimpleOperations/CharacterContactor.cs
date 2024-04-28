namespace SimpleOperations;

public class CharacterContactor
{
    public static void Count()
    {
        string text = Console.ReadLine();

        Console.WriteLine($"With spaces {text.Length}");
        Console.WriteLine($"No spaces {text.Trim().Length}");
    }
}
