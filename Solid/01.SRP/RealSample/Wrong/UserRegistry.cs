namespace Solid._01.SRP.RealSample.Wrong;

/// <summary>
/// En esta clase se muestra un ejemplo de una clase que viola el principio SRP.
/// Esto es debido a que la clase tiene más de una razón de cambio, ya que tiene
/// la responsabilidad de encriptar la contraseña y guardar el usuario en la base de datos.
/// Si el día de mañana cambia la forma de encriptar la contraseña, la clase deberá ser modificada.
/// </summary>
public class UserRegistry
{
    public void CreateUser(string email, string password)
    {
        // Encriptar la contraseña
        string encryptedPassword = EncryptPassword(password);

        // Crear el usuario
        User user = new() { Email = email, Password = encryptedPassword };

        // Guardar el usuario
        SaveUser(user);
    }

    private string EncryptPassword(string password)
    {
        // Código para encriptar la contraseña
        return "encryptedPassword"; // Simulación de encriptación
    }

    private void SaveUser(User user)
    {
        // Código para guardar el usuario en la base de datos
    }
}
