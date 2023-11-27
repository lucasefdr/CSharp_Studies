using DesignPatterns;
#region Strategy

var standardShipping = new StandardShippingStrategy();
var shoppingCart = new ShoppingCart(standardShipping);
Console.WriteLine($"Standard shipping cost: {shoppingCart.CalculateShipping(100)}");

shoppingCart.SetShippingStrategy(new ExpressShippingStrategy());
Console.WriteLine($"Express shipping cost: {shoppingCart.CalculateShipping(100)}");
#endregion