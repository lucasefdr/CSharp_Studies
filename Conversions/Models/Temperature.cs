namespace Conversions;

record Temperature
{
    public double Celsius { get; set; }

    // Implicit conversion from Celsius to Fahrenheit
    public static implicit operator double(Temperature temperature) => temperature.Celsius * 9 / 5 + 32;
}