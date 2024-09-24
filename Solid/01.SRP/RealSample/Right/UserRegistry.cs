namespace Solid._01.SRP.RealSample.Right;

/// <summary>
/// En esta clase se muestra un ejemplo de una clase que respeta el principio SRP.
/// Esto es debido a que la clase tiene una sola razón de cambio.
/// </summary>
public class UserRegistry
{
    private readonly PasswordEncryptor _passwordEncryptor;
    private readonly UserRepository _userRepository;

    public UserRegistry(PasswordEncryptor passwordEncryptor, UserRepository userRepository)
    {
        _passwordEncryptor = passwordEncryptor;
        _userRepository = userRepository;
    }

    public void CreateUser(string email, string password)
    {
        string encryptedPassword = _passwordEncryptor.EncryptPassword(password);
        User user = new() { Email = email, Password = encryptedPassword };
        _userRepository.SaveUser(user);
    }
}

public class PasswordEncryptor
{
    public string EncryptPassword(string password)
    {
        // Código para encriptar la contraseña
        return "encryptedPassword"; // Simulación de encriptación
    }
}

public class UserRepository
{
    public void SaveUser(User user)
    {
        // Código para guardar el usuario en la base de datos
    }
}
