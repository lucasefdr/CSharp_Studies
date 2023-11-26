#region Implicit Operator
using Conversions;

Temperature tempCelsius = new() { Celsius = 100 };
double tempFahrenheit = tempCelsius; // Implicit conversion from Celsius to Fahrenheit 

Console.WriteLine(tempCelsius.Celsius);
Console.WriteLine(tempFahrenheit);


// Phone = Object
Phone phone = new("55", "11", "999999999");

// Convert to string
Console.WriteLine(phone);

// Create a string
string telephone = "55 11 987765544";

// Covnvert to Phone
phone = telephone;

Console.WriteLine(phone);
#endregion