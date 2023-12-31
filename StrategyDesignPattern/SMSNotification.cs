namespace StrategyDesignPattern;

public class SMSNotification : INotificationStrategy
{
    public void SendNotification(string message)
    {
        Console.WriteLine($"{message}");
        Console.WriteLine("This is an SMS Notifcation");
    }
}
