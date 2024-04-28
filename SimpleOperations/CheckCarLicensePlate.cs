namespace SimpleOperations;

public class CheckCarLicensePlate
{
    public static bool CheckPlate()
    {
        string plate = Console.ReadLine();

        if (plate.Length != 7)
            return false;

        char[] firstPart = plate.Substring(0, 3).ToCharArray();
        char[] lastPart = plate.Substring(plate.Length - 4).ToCharArray();

        for (int i = 0;  i < firstPart.Length; i++)
            if (!IsNumerical(firstPart[i]))
                return false;

        for (int i = 0; i < lastPart.Length; i++)
            if (!IsNumerical(lastPart[i]))
                return false;

        return true;
    }

    private static bool IsNumerical(char value)
    {
        try
        {
            Convert.ToInt32(value);

            return true;
        }
        catch
        {
            return false;
        }
    }
}
