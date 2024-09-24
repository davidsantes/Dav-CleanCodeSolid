namespace Solid._02.OCP.Pirates.Wrong;

/// <summary>
/// Clase que viola el principio OCP. La clase PirateService tiene más de una razón de cambio.
/// En función del tipo de pirata, se realiza un ataque diferente.
/// </summary>
public class PirateService
{
    public void Attack(string pirateType)
    {
        if (pirateType == "Sword")
        {
            Console.WriteLine("Attacks with a sword!");
        }
        else if (pirateType == "Gun")
        {
            Console.WriteLine("Attacks with a gun!");
        }
        // Si se agrega un nuevo tipo de ataque, se debe modificar esta clase
        else if (pirateType == "Cannon")
        {
            Console.WriteLine("Attacks with a cannon!");
        }
        else
        {
            throw new ArgumentException("Unknown pirate type");
        }
    }
}
