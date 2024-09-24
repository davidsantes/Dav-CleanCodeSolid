namespace Solid._05.DIP.Pirates.Right;

/// <summary>
/// En este ejemplo, utilizamos una interfaz IWeapon para invertir la dependencia,
/// de modo que la clase Pirate dependa de una abstracción en lugar de una implementación
/// concreta.
/// </summary>
public interface IWeapon
{
    void Attack();
}

public class Sword : IWeapon
{
    public void Attack()
    {
        Console.WriteLine("Attacking with a sword!");
    }
}

public class Gun : IWeapon
{
    public void Attack()
    {
        Console.WriteLine("Attacking with a gun!");
    }
}

public class Pirate
{
    private readonly IWeapon _weapon;

    public Pirate(IWeapon weapon)
    {
        _weapon = weapon;
    }

    public void Attack()
    {
        _weapon.Attack();
    }
}

class Program
{
    static void Main(string[] args)
    {
        IWeapon sword = new Sword();
        Pirate pirateWithSword = new Pirate(sword);
        pirateWithSword.Attack();

        IWeapon gun = new Gun();
        Pirate pirateWithGun = new Pirate(gun);
        pirateWithGun.Attack();
    }
}
