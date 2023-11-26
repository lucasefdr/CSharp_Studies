namespace SOLID;

public class OrderService(IRepository repository) : IOrderService
{
    // Apply the Dependency Inversion Principle (DIP) by injecting the repository
    public string Checkout(Order order)
    {
        if (order.Client is null) return "Client is required";

        repository.Save(order);

        return string.Empty;
    }
}
