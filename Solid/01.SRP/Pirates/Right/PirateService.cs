namespace Solid._01.SRP.Pirates.Right;

/// <summary>
/// Clase que respeta el principio SRP. La clase PirateService tiene una sola razón de cambio.
/// Dividiremos las responsabilidades en clases separadas:
/// 1.	PirateValidator: Se encargará de la validación de los datos del pirata.
/// 2.	PirateFactory: Se encargará de la creación del objeto Pirate.
/// 3.	PirateRepository: Se encargará de guardar el pirata en la base de datos.
/// 4.	PirateService: Coordinará las operaciones utilizando las clases anteriores.
/// </summary>
public class PirateService
{
    private readonly PirateValidator _validator;
    private readonly PirateFactory _factory;
    private readonly PirateRepository _repository;

    public PirateService(
        PirateValidator validator,
        PirateFactory factory,
        PirateRepository repository
    )
    {
        _validator = validator;
        _factory = factory;
        _repository = repository;
    }

    public void AddPirate(string name, int age)
    {
        _validator.Validate(name, age);
        Pirate pirate = _factory.CreatePirate(name, age);
        _repository.SavePirate(pirate);
    }
}

public class PirateValidator
{
    public void Validate(string name, int age)
    {
        if (string.IsNullOrEmpty(name))
        {
            throw new ArgumentException("Name cannot be null or empty");
        }

        if (age <= 0)
        {
            throw new ArgumentException("Age must be greater than zero");
        }
    }
}

public class PirateFactory
{
    public Pirate CreatePirate(string name, int age)
    {
        return new Pirate { Name = name, Age = age };
    }
}

public class PirateRepository
{
    public void SavePirate(Pirate pirate)
    {
        // Código para guardar el pirata en la base de datos
    }
}
