using System.Globalization;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Parse;

public static class Exercises
{
    public static void NumericParsing()
    {
        Console.Write("Enter a number: ");
        string strNumber = Console.ReadLine()!;

        if (int.TryParse(strNumber, out int number))
            Console.WriteLine($"Parsed value: {number} - Parsed type: {number.GetType()}");
        else
            Console.WriteLine("Invalid input. Cannot parse.");
    }

    public static void DateParsing()
    {
        Console.Write("Enter a date: ");
        string strDate = Console.ReadLine()!;

        if (DateTime.TryParse(strDate, CultureInfo.GetCultureInfo("pt-br"), out DateTime date))
            Console.WriteLine($"Parsed value: {date} - Parsed type: {date.GetType()}");
        else
            Console.WriteLine("Invalid input. Cannot parse.");
    }

    public static void DayOfWeekParsing()
    {
        Console.Write("Enter a day of week: ");
        string strDayOfWeek = Console.ReadLine()!;

        if (Enum.TryParse(strDayOfWeek, out DayOfWeek dayOfWeek))
            Console.WriteLine($"Parsed value: {dayOfWeek} - Parsed type: {dayOfWeek.GetType()}");
        else
            Console.WriteLine("Invalid input. Cannot parse.");
    }

    enum DayOfWeek { Sunday, Monday, Tuesday, Wednesday, Thursday, Friday, Saturday }
}
