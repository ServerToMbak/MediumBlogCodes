internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        ISendNotifaction sms = new MailNotifcation();


        sms.SendNotification();
        sms.SendNotification2();
        sms.SendNotification3();

    }

    //Bir olayın bir durumu/algoritma varsa strategy design pattern -davranıisal design pattern.


    interface ISendNotifaction
    {
        void SendNotification();


        void SendNotification2();

        void SendNotification3();

    }


    class MailNotifcation : ISendNotifaction
    {
        public void SendNotification()
        {
            Console.WriteLine("Notication send by mail");
        }

        public void SendNotification2()
        {
            Console.WriteLine("Notication send by mail");
        }

        public void SendNotification3()
        {
            Console.WriteLine("Notication send by mail");
        }
    }


    class SmsNotifaction : ISendNotifaction
    {
        public void SendNotification()
        {
            Console.WriteLine("Notication send by sms");
        }

        public void SendNotification2()
        {
            Console.WriteLine("Notication send by sms");
        }

        public void SendNotification3()
        {
            Console.WriteLine("Notication send by sms");
        }
    }

}