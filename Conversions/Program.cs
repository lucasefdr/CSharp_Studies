#region Implicit Operator
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

/* Records */
record Temperature
{
    public double Celsius { get; set; }

    // Implicit conversion from Celsius to Fahrenheit
    public static implicit operator double(Temperature temperature) => temperature.Celsius * 9 / 5 + 32;
}

record Phone(string CountryCode, string Area, string Number)
{
    public static implicit operator string(Phone phone) => $"+{phone.CountryCode} ({phone.Area}) {phone.Number}";

    public static implicit operator Phone(string phone)
    {
        var data = phone.Split(" ");
        return new Phone(data[0], data[1], data[2]);
    }
}


#endregion