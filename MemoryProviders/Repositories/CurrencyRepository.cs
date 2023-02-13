using Data.Entities;
using Data.Repositories;

namespace MemoryProviders.Repositories;

public class CurrencyRepository : EntityRepository<Currency>, ICurrencyRepository
{
    public Currency? GetByShortName(string shortName)
    {
        foreach (var item in _items)
            if (String.Equals(item.ShortName, shortName, StringComparison.InvariantCultureIgnoreCase))
                return item;

        return null;
    }
}
