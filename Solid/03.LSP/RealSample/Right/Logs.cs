namespace Solid._03.LSP.RealSample.Right;

public abstract class Logger
{
    public abstract void Log(string message);
}

public class FileLogger : Logger
{
    private readonly string _filePath;

    public FileLogger(string filePath)
    {
        _filePath = filePath;
    }

    public override void Log(string message)
    {
        File.AppendAllText(_filePath, message + Environment.NewLine);
    }
}

/// <summary>
/// En este ejemplo, todas las subclases de Logger respetan el comportamiento esperado de la clase base,
/// asegurando que cualquier subclase pueda ser utilizada en lugar de la clase base sin problemas.
/// </summary>
public class NullLogger : Logger
{
    public override void Log(string message)
    {
        // NullLogger simplemente no hace nada, respetando el comportamiento esperado
    }
}

public class LoggerService
{
    private readonly Logger _logger;

    public LoggerService(Logger logger)
    {
        _logger = logger;
    }

    public void LogMessage(string message)
    {
        _logger.Log(message);
    }
}

class Program
{
    static void Main(string[] args)
    {
        LoggerService loggerService = new LoggerService(new NullLogger());
        loggerService.LogMessage("This is a test message.");
    }
}
