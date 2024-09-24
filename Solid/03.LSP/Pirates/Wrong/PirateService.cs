namespace Solid.LSP.Wrong;

public class Pirate
{
    public virtual void Attack()
    {
        Console.WriteLine("Attacks with a weapon!");
    }
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
        // PeacefulPirate no ataca, lo que rompe el comportamiento esperado de la clase base
        throw new InvalidOperationException("PeacefulPirate does not attack!");
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
        _pirates = new List<Pirate>
        {
            new SwordPirate(),
            new GunPirate(),
            new PeacefulPirate() // Esto causará una excepción
        };
    }

    public void ExecuteAttacks()
    {
        foreach (var pirate in _pirates)
        {
            try
            {
                _pirateService.MakePirateAttack(pirate);
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
