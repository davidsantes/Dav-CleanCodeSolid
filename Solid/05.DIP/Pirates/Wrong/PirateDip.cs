namespace Solid._05.DIP.Pirates.Wrong;

public class Sword
{
    public void Attack()
    {
        Console.WriteLine("Attacking with a sword!");
    }
}

/// <summary>
/// En este ejemplo, la clase Pirate depende directamente de la clase Sword,
/// lo que crea una dependencia fuerte entre las dos clases.
/// Esto hace que sea difícil cambiar la implementación del arma que el pirata
/// usa sin modificar la clase Pirate.
/// Esto viola el Principio de Inversión de Dependencias porque las clases de alto nivel
/// (como Pirate) no deben depender de clases de bajo nivel (como Sword).
/// </summary>
public class Pirate
{
    private readonly Sword _sword;

    public Pirate()
    {
        _sword = new Sword();
    }

    public void Attack()
    {
        _sword.Attack();
    }
}

class Program
{
    static void Main(string[] args)
    {
        Pirate pirate = new Pirate();
        pirate.Attack();
    }
}
