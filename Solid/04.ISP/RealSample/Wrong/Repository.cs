namespace Solid._04.ISP.RealSample.Wrong;

public interface IRepository<T>
{
    void Add(T item);
    void Remove(T item);
    T GetById(int id);
    IEnumerable<T> GetAll();
    void SaveChanges();
}

public class InMemoryRepository<T> : IRepository<T>
{
    private readonly List<T> _items = [];

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
        // InMemoryRepository no necesita implementar GetById, pero está obligado a hacerlo
        throw new NotImplementedException();
    }

    public IEnumerable<T> GetAll()
    {
        return _items;
    }

    public void SaveChanges()
    {
        // InMemoryRepository no necesita implementar SaveChanges, pero está obligado a hacerlo
        throw new NotImplementedException();
    }
}

public class DataService<T>
{
    private readonly IRepository<T> _repository;

    public DataService(IRepository<T> repository)
    {
        _repository = repository;
    }

    public void AddItem(T item)
    {
        _repository.Add(item);
        _repository.SaveChanges();
    }

    public IEnumerable<T> GetAllItems()
    {
        return _repository.GetAll();
    }
}
