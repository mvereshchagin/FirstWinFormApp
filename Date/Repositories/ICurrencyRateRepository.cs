using Data.Entities;

namespace Data.Repositories;

public interface ICurrencyRateRepository : IEntityRepository<CurrencyRate>
{
    double? GetRateByCurrencies(Currency currencyFrom, Currency currencyTo);
}
