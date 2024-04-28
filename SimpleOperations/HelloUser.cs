namespace SimpleOperations;

public class HelloUser
{
    public static void Hello()
    {
        string name = Console.ReadLine();

        Console.WriteLine($"Olá {name}! Seja muito bem-vindo!");
    }
}
