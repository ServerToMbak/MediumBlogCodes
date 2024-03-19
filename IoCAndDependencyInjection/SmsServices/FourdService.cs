namespace IoCAndDependencyInjection.SmsServices
{
    public class FourdService : ISmsService
    {
        public void SendSms()
        {
            Console.WriteLine("Sms sending by fourd service");
        }
    }
}
