namespace Solid._03.LSP.RealSample.Wrong;

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
/// En este ejemplo, la clase NullLogger no respeta el comportamiento esperado de la
/// clase base Logger, ya que lanza una excepción en lugar de realizar la operación de registro.
/// Esto viola el principio de sustitución de Liskov porque NullLogger no puede ser sustituido
/// por Logger sin alterar la funcionalidad del programa.
/// </summary>
public class NullLogger : Logger
{
    public override void Log(string message)
    {
        // NullLogger lanza una excepción, lo que rompe el comportamiento esperado
        throw new InvalidOperationException("NullLogger does not support logging.");
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

public class Program
{
    static void Main(string[] args)
    {
        LoggerService loggerService = new LoggerService(new NullLogger());
        try
        {
            loggerService.LogMessage("This is a test message.");
        }
        catch (InvalidOperationException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}
