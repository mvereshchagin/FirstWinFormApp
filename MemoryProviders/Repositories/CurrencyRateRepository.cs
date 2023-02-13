using Data.Entities;
using Data.Repositories;

namespace MemoryProviders.Repositories;

public class CurrencyRateRepository : EntityRepository<CurrencyRate>, ICurrencyRateRepository
{
    public double? GetRateByCurrencies(Currency currencyFrom, Currency currencyTo)
    {
        foreach (var item in _items)
            if (item.CurrencyTo == currencyTo && item.CurrencyFrom == currencyFrom)
                return item.Rate;

        return null;
    }
}
