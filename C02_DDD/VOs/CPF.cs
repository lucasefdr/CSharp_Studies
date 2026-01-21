namespace C02_DDD.VOs;

public record CPF
{
    public string Value { get; }

    private CPF(string value)
    {
        Value = value;
    }

    public static CPF Create(string value)
    {
        if (string.IsNullOrWhiteSpace(value))
            throw new InvalidOperationException("CPF cannot be null or empty");

        if (value.Length != 11)
            throw new InvalidOperationException("CPF must have 11 digits");

        return new CPF(value);
    }
}