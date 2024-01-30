namespace IoCAndDependencyInjection.SmsServices
{
    public class ThirdService : ISmsService
    {
        public void SendSms()
        {
            Console.WriteLine("Sms sending by third service");
        }
    }
}
