namespace SimpleOperations;

public class CurrentDate
{
    public static void Date()
    {
        DateTime date = DateTime.Now;
        Console.WriteLine($"{date.ToLongDateString()} {date.Hour}:{date.Minute}:{date.Second}");

        Console.WriteLine(date.ToShortDateString());

        Console.WriteLine(date.Hour);

        Console.WriteLine(date.ToString("d MMMM yyyy"));
    }
}
