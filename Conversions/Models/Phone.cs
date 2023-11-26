namespace Conversions;

record Phone(string CountryCode, string Area, string Number)
{
    public static implicit operator string(Phone phone) => $"+{phone.CountryCode} ({phone.Area}) {phone.Number}";

    public static implicit operator Phone(string phone)
    {
        var data = phone.Split(" ");
        return new Phone(data[0], data[1], data[2]);
    }
}
