using Data.Entities;
using Data.Repositories;

namespace MemoryProviders.Repositories;

public class EntityRepository<T> : IEntityRepository<T> where T : class, IEntityItem
{
    protected List<T> _items = new();

    public IEnumerable<T> All => _items;

    public void Add(T item)
    {
        _items.Add(item);
    }

    public void Delete(T item)
    {
        _items.Remove(item);
    }

    public T? GetById(int id)
    {
        foreach (var item in _items)
            if (item.Id == id)
                return item;

        return null;
    }

    public void Update(T item)
    {
        var foundItem = GetById(item.Id);
        if (foundItem is null)
            return;
        foundItem = item;
    }
}
