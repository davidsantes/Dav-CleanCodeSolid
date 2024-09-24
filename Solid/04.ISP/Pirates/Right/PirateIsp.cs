namespace Solid._04.ISP.Pirates.Right;

/// <summary>
/// En este ejemplo, las interfaces se dividen en interfaces más pequeñas y específicas,
/// de modo que las clases solo implementan los métodos que realmente necesitan.
/// </summary>
public interface IAttack
{
    void Attack();
}

public interface ISail
{
    void Sail();
}

/// <summary>
/// Clase que implementa solo la interfaz IAttack porque solo necesita atacar.
/// </summary>
public class SwordPirate : IAttack
{
    public void Attack()
    {
        Console.WriteLine("Sword pirate attacks!");
    }
}

/// <summary>
/// Clase que implementa tanto IAttack como ISail porque necesita atacar y navegar.
/// </summary>
public class CaptainPirate : IAttack, ISail
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
