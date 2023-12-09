using System.Globalization;

namespace Parse;

public static class Studies
{
    public static void ParseStudies(string strNumber)
    {
        int number = int.Parse(strNumber);
        Console.WriteLine(number);
    }

    public static void TryParseStudies(string strDate)
    {
        if (DateTime.TryParse(strDate, CultureInfo.GetCultureInfo("pt-br"), out DateTime date))
        {
            Console.WriteLine($"Parsed value: {date}.");
        }
        else
        {
            Console.WriteLine("Invalid input.");
        }
    }

    enum Animal { Cat, Dog }

    public static void TryParseEnumStudies(string strAnimalEnum)
    {
        if (Enum.TryParse(strAnimalEnum, out Animal day))
        {
            Console.WriteLine($"Parsed value: {day}.");
        }
        else
        {
            Console.WriteLine("Invalid input.");
        }
    }
}


