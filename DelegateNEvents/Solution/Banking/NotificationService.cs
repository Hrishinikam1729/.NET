namespace NotificationS;

public class NotificationService
{
    public static void SendSMS(string to, string message)
    {
        Console.WriteLine(to + message);
    }

    public static void SendEmail(string to, string message)
    {
        Console.WriteLine(to + message);
    }

    public static void SendWhatsappMessage(string to, string message)
    {
        Console.WriteLine(to + message);
    }

}