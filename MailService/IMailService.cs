namespace MailService
{
    public interface IMailService
    {
        void SendEmailWithMailKitPackage(string subject,string body, string mail);
    }
}
