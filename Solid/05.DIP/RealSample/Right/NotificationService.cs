namespace Solid._05.DIP.RealSample.Right;

/// <summary>
/// En este ejemplo, utilizamos una interfaz INotificationSender para invertir la
/// dependencia, de modo que la clase NotificationService dependa de una abstracción
/// en lugar de una implementación concreta.
/// </summary>
public interface INotificationSender
{
    void Send(string message);
}

public class EmailSender : INotificationSender
{
    public void Send(string message)
    {
        Console.WriteLine($"Sending email: {message}");
    }
}

public class SmsSender : INotificationSender
{
    public void Send(string message)
    {
        Console.WriteLine($"Sending SMS: {message}");
    }
}

public class NotificationService
{
    private readonly INotificationSender _notificationSender;

    public NotificationService(INotificationSender notificationSender)
    {
        _notificationSender = notificationSender;
    }

    public void Notify(string message)
    {
        _notificationSender.Send(message);
    }
}

class Program
{
    static void Main(string[] args)
    {
        INotificationSender emailSender = new EmailSender();
        NotificationService emailNotificationService = new NotificationService(emailSender);
        emailNotificationService.Notify("Hello, this is an email notification!");

        INotificationSender smsSender = new SmsSender();
        NotificationService smsNotificationService = new NotificationService(smsSender);
        smsNotificationService.Notify("Hello, this is an SMS notification!");
    }
}
