using Data.Entities;
using Data.Repositories;
using System.Text.Json;

namespace FileProviders.Repositories;

public class EntityRepository<T> : IEntityRepository<T> where T : class, IEntityItem
{
    private const string _fileName = "_users.json";

    public IEnumerable<T> All
    {
        get
        {
            return Read();
        }
    }

    public void Add(T item)
    {
        var items = Read();
        items.Add(item);
        Overwrite(items);
    }

    public void Delete(T item)
    {
        var items = Read();
        items.Remove(item);
        Overwrite(items);
    }

    public T? GetById(int id)
    {
        foreach (var item in All)
            if (item.Id == id)
                return item;

        return null;
    }

    public void Update(T item)
    {
        throw new NotImplementedException();
    }

    private void Overwrite(List<T> items)
    {
        try
        {
            using var stream = File.Open(_fileName, FileMode.OpenOrCreate);
            JsonSerializer.Serialize<List<T>>(stream, items);
        }
        catch
        {}
    }

    private List<T> Read()
    {
        try
        {
            using var stream = File.Open(_fileName, FileMode.OpenOrCreate);
            return JsonSerializer.Deserialize<List<T>>(stream) ?? new();
        }
        catch
        {
            return new();
        }
    }
}
