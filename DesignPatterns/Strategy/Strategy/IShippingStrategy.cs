namespace DesignPatterns;

public interface IShippingStrategy
{
    decimal CalculateShippingCost(decimal order);
}
