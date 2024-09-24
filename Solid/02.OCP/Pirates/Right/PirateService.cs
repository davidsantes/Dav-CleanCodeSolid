namespace Solid._02.OCP.Pirates.Right;

/// <summary>
/// Clase que no viola el principio OCP. La clase PirateService tiene una sola razón de cambio.
/// </summary>
public class PirateService
{
    public void Attack(Pirate pirate)
    {
        pirate.Attack();
    }
}

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

public class CannonPirate : Pirate
{
    public override void Attack()
    {
        Console.WriteLine("Attacks with a cannon!");
    }
}

public class EveryBodyAttacks
{
    private readonly PirateService _pirateService;
    private readonly Pirate _swordPirate;
    private readonly Pirate _gunPirate;
    private readonly Pirate _cannonPirate;

    public EveryBodyAttacks()
    {
        _pirateService = new PirateService();
        _swordPirate = new SwordPirate();
        _gunPirate = new GunPirate();
        _cannonPirate = new CannonPirate();
    }

    public void ExecuteAttacks()
    {
        _pirateService.Attack(_swordPirate); // Output: Attacks with a sword!
        _pirateService.Attack(_gunPirate); // Output: Attacks with a gun!
        _pirateService.Attack(_cannonPirate); // Output: Attacks with a cannon!
    }
}
