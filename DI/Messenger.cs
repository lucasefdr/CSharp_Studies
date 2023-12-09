namespace DI;

// Implementation of IMessenger
public class Messenger : IMessenger
{
    // Send a message
    public void SendMessage(string message)
    {
        Console.WriteLine("Training DI...");
    }
}
