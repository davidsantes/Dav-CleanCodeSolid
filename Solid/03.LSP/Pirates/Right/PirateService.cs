using System.Collections.Generic;

namespace Solid.LSP.Right;

/// <summary>
/// Clase que respeta el principio de sustitución de Liskov debido
/// a que la clase base define un comportamiento común para todas las clases derivadas.
/// </summary>
public abstract class Pirate
{
    public abstract void Attack();
}

public class SwordPirate : Pirate
{
    public override void Attack()
    {
        Console.WriteLine("Attacks with a sword!");
    }
}

public class GunPirate : Pirate
{
    public override void Attack()
    {
        Console.WriteLine("Attacks with a gun!");
    }
}

public class PeacefulPirate : Pirate
{
    public override void Attack()
    {
        // PeacefulPirate realiza una acción alternativa en lugar de lanzar una excepción
        Console.WriteLine("Offers peace instead of attacking.");
    }
}

public class PirateService
{
    public void MakePirateAttack(Pirate pirate)
    {
        pirate.Attack();
    }
}

public class EveryBodyAttacks
{
    private readonly PirateService _pirateService;
    private readonly List<Pirate> _pirates;

    public EveryBodyAttacks()
    {
        _pirateService = new PirateService();
        _pirates = new List<Pirate> { new SwordPirate(), new GunPirate(), new PeacefulPirate() };
    }

    public void ExecuteAttacks()
    {
        foreach (var pirate in _pirates)
        {
            _pirateService.MakePirateAttack(pirate);
        }
    }
}
