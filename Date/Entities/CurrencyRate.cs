namespace Data.Entities;

public class CurrencyRate : IEntityItem
{
    public int Id { get; set; }

    public Currency CurrencyFrom { get; set; } = null!;

    public Currency CurrencyTo { get; set; } = null!;

    public float Rate { get; set; }
}
