namespace Solid._04.ISP.Pirates.Wrong;

public interface IPirate
{
    void Attack();
    void Sail();
}

/// <summary>
/// En este ejemplo, la clase SwordPirate se ve obligada a implementar el método Sail de la interfaz
/// IPirate, aunque no tiene sentido para esta clase.
/// Esto viola el Principio de Segregación de Interfaces porque las clases no deben estar
/// obligadas a implementar métodos que no utilizan.
/// </summary>
public class SwordPirate : IPirate
{
    public void Attack()
    {
        Console.WriteLine("Sword pirate attacks!");
    }

    public void Sail()
    {
        // SwordPirate no necesita implementar Sail, pero está obligado a hacerlo
        throw new NotImplementedException();
    }
}

public class CaptainPirate : IPirate
{
    public void Attack()
    {
        Console.WriteLine("Captain pirate attacks!");
    }

    public void Sail()
    {
        Console.WriteLine("Captain pirate sails the ship!");
    }
}
