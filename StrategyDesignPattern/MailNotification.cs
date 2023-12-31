namespace StrategyDesignPattern;

public class MailNotification : INotificationStrategy
{
    public void SendNotification(string message)
    {
        Console.WriteLine($"{message}");
        Console.WriteLine("This is an Email Notifcation");
    }
}
