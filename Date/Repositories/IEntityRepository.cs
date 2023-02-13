namespace Data.Repositories;

public interface IEntityRepository<T>
{
    void Add(T item);

    void Update(T item);

    void Delete(T item);

    IEnumerable<T> All { get; }

    T? GetById(int id);
}
