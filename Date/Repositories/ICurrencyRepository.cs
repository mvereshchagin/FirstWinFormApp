using Data.Entities;

namespace Data.Repositories;

public interface ICurrencyRepository : IEntityRepository<Currency>
{
    Currency? GetByShortName(string shortName);
}
