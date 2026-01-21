using System.Text.RegularExpressions;

namespace C02_DDD.VOs;

public partial record Email
{
    private string Address { get; }

    private Email(string address)
    {
        Address = address;
    }

    public static Email Create(string address)
    {
        if (string.IsNullOrWhiteSpace(address) || !EmailRegex().IsMatch(address))
        {
            throw new ArgumentException("Invalid email format.", nameof(address));
        }

        return new Email(address);
    }

    public override string ToString() => Address;

    [GeneratedRegex(@"^[^@\s]+@[^@\s]+\.[^@\s]+$", RegexOptions.IgnoreCase | RegexOptions.Compiled, "pt-BR")]
    private static partial Regex EmailRegex();
}