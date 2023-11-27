namespace DesignPatterns;

// The strategy is injected into the context
public class ShoppingCart
{
    private IShippingStrategy _shippingStrategy;

    public ShoppingCart(IShippingStrategy shippingStrategy)
    {
        _shippingStrategy = shippingStrategy;
    }

    public decimal CalculateShipping(decimal order) => _shippingStrategy.CalculateShippingCost(order);

    public void SetShippingStrategy(IShippingStrategy shippingStrategy)
    {
        _shippingStrategy = shippingStrategy;
    }
}