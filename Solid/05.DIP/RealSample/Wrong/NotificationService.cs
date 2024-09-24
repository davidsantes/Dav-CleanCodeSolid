namespace Solid._05.DIP.RealSample.Wrong;

public class EmailSender
{
    public void SendEmail(string message)
    {
        Console.WriteLine($"Sending email: {message}");
    }
}

/// <summary>
/// En este ejemplo, la clase NotificationService depende directamente de la clase
/// EmailSender, lo que crea una dependencia fuerte y hace que sea difícil cambiar la
/// implementación del método de notificación sin modificar la clase NotificationService.
/// Esto viola el Principio de Inversión de Dependencias porque las clases de alto nivel
/// (como NotificationService) no deben depender de clases de bajo nivel (como EmailSender).
/// </summary>
public class NotificationService
{
    private readonly EmailSender _emailSender;

    public NotificationService()
    {
        _emailSender = new EmailSender();
    }

    public void Notify(string message)
    {
        _emailSender.SendEmail(message);
    }
}

class Program
{
    static void Main(string[] args)
    {
        NotificationService notificationService = new NotificationService();
        notificationService.Notify("Hello, this is a notification!");
    }
}
