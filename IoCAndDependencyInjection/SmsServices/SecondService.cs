namespace IoCAndDependencyInjection.SmsServices;

public class SecondService : ISmsService
{
    public void SendSms()
    {
        Console.WriteLine("Sms sending by second Service");
    }
}
