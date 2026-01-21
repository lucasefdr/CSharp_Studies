namespace C02_DDD.VOs;

public record Money
{
    public decimal Amount { get; }
    public string Currency { get; }

    public Money(decimal amount, string currency)
    {
        if (string.IsNullOrWhiteSpace(currency))
            throw new ArgumentException("A moeda é obrigatória.", nameof(currency));

        if (amount < 0)
            throw new InvalidOperationException("O valor não pode ser negativo.");

        Amount = amount;
        Currency = currency.ToUpper();
    }


    public static Money Sum(Money a, Money b)
    {
        return a.Currency != b.Currency
            ? throw new InvalidOperationException("Não é possível somar moedas diferentes.")
            : new Money(a.Amount + b.Amount, a.Currency);
    }
}