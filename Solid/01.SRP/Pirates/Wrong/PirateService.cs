namespace Solid._01.SRP.Pirates.Wrong;

/// <summary>
/// Clase que viola el principio SRP. La clase PirateService tiene más de una razón de cambio.
/// En este ejemplo, la clase PirateServiceWrong está manejando tres responsabilidades diferentes:
/// 1.	Validar datos del pirata: La lógica para validar los datos del pirata está dentro de la misma clase.
/// 2.	Crear el pirata: La creación del objeto Pirate también está dentro de la misma clase.
/// 3.	Guardar el pirata: La lógica para guardar el pirata en la base de datos está dentro de la misma clase.
/// </summary>
public class PirateService
{
    public void AddPirate(string name, int age)
    {
        // Validar datos del pirata
        if (string.IsNullOrEmpty(name))
        {
            throw new ArgumentException("Name cannot be null or empty");
        }

        if (age <= 0)
        {
            throw new ArgumentException("Age must be greater than zero");
        }

        // Crear el pirata
        Pirate pirate = new() { Name = name, Age = age };

        // Guardar el pirata
        SavePirate(pirate);
    }

    private void SavePirate(Pirate pirate)
    {
        // Código para guardar el pirata en la base de datos
    }
}
