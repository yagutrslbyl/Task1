using ConsoleApp10;

class Program
{
    static void Main()
    {
        EmailService email = new EmailService();
        SMSService sms = new SMSService();
        PushNotificationService push = new PushNotificationService();


        Notifier notifier = new Notifier();

        NotificationHandler del = email.SendEmail;
        //notifier.SendNotification(del, "Sikayet");
        del += sms.SendSMS;
        del += push.SendPush;
        notifier.SendNotification(del, "yaqut");
    }
}

