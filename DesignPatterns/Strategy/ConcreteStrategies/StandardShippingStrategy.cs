namespace DesignPatterns;

public class StandardShippingStrategy : IShippingStrategy
{
    public decimal CalculateShippingCost(decimal order)
    {
        return order * 0.05m;
    }
}
