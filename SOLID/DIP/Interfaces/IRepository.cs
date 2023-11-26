namespace SOLID;

public interface IRepository
{
    void Save(Order order);
    Order Get(string name);
}
