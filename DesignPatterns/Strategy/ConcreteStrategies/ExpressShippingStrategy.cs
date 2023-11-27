namespace DesignPatterns;

public class ExpressShippingStrategy : IShippingStrategy
{
    public decimal CalculateShippingCost(decimal order)
    {
        return order * 0.1m;
    }
}
