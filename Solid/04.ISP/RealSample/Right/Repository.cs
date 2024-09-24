namespace Solid._04.ISP.RealSample.Right;

public interface IAddRepository<T>
{
    void Add(T item);
}

public interface IRemoveRepository<T>
{
    void Remove(T item);
}

public interface IReadRepository<T>
{
    T GetById(int id);
    IEnumerable<T> GetAll();
}

public interface ISaveRepository
{
    void SaveChanges();
}

/// <summary>
/// lase que implementa IAddRepository, IRemoveRepository, y IReadRepository porque
/// necesita agregar, remover y leer elementos.
/// No implementa ISaveRepository porque no necesita guardar cambios.
/// </summary>
public class InMemoryRepository<T> : IAddRepository<T>, IRemoveRepository<T>, IReadRepository<T>
{
    private readonly List<T> _items = new List<T>();

    public void Add(T item)
    {
        _items.Add(item);
    }

    public void Remove(T item)
    {
        _items.Remove(item);
    }

    public T GetById(int id)
    {
        // Implementación simple para obtener un elemento por ID
        return _items[id];
    }

    public IEnumerable<T> GetAll()
    {
        return _items;
    }
}

/// <summary>
/// Clase que implementa IAddRepository, IRemoveRepository, IReadRepository,
/// y ISaveRepository porque necesita todas estas funcionalidades.
/// </summary>
public class DatabaseRepository<T>
    : IAddRepository<T>,
        IRemoveRepository<T>,
        IReadRepository<T>,
        ISaveRepository
{
    // Simulación de una base de datos
    private readonly List<T> _database = new List<T>();

    public void Add(T item)
    {
        _database.Add(item);
    }

    public void Remove(T item)
    {
        _database.Remove(item);
    }

    public T GetById(int id)
    {
        // Implementación simple para obtener un elemento por ID
        return _database[id];
    }

    public IEnumerable<T> GetAll()
    {
        return _database;
    }

    public void SaveChanges()
    {
        // Simulación de guardar cambios en la base de datos
        Console.WriteLine("Changes saved to the database.");
    }
}

/// <summary>
/// Clase que utiliza las interfaces IAddRepository, IReadRepository, y ISaveRepository
/// para realizar operaciones específicas.
/// </summary>
public class DataService<T>
{
    private readonly IAddRepository<T> _addRepository;
    private readonly IReadRepository<T> _readRepository;
    private readonly ISaveRepository _saveRepository;

    public DataService(
        IAddRepository<T> addRepository,
        IReadRepository<T> readRepository,
        ISaveRepository saveRepository
    )
    {
        _addRepository = addRepository;
        _readRepository = readRepository;
        _saveRepository = saveRepository;
    }

    public void AddItem(T item)
    {
        _addRepository.Add(item);
        _saveRepository.SaveChanges();
    }

    public IEnumerable<T> GetAllItems()
    {
        return _readRepository.GetAll();
    }
}

class Program
{
    static void Main(string[] args)
    {
        var inMemoryRepo = new InMemoryRepository<string>();
        var dataService = new DataService<string>(inMemoryRepo, inMemoryRepo, null);

        dataService.AddItem("Item 1");
        foreach (var item in dataService.GetAllItems())
        {
            Console.WriteLine(item);
        }

        var dbRepo = new DatabaseRepository<string>();
        var dbDataService = new DataService<string>(dbRepo, dbRepo, dbRepo);

        dbDataService.AddItem("Item 2");
        foreach (var item in dbDataService.GetAllItems())
        {
            Console.WriteLine(item);
        }
    }
}
