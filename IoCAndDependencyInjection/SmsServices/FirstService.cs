namespace IoCAndDependencyInjection.SmsServices;

public class FirstService : ISmsService
{
    public void SendSms()
    {
        Console.WriteLine("Sms sending by first Service");
    }
}
