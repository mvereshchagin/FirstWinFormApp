namespace Data.Entities;

public class Currency : IEntityItem, IEquatable<Currency>
{
    public int Id { get; set; }

    public string FullName { get; set; } = null!;

    public string ShortName { get; set; } = null!;

    public bool Equals(Currency? other)
    {
        if (other is null)
            return false;

        return String.Equals(this.ShortName, other.ShortName, StringComparison.InvariantCultureIgnoreCase);
    }

    public static bool operator ==(Currency currency1, Currency currency2)
    {
        if (currency1 is null && currency2 is null)
            return true;

        if (currency1 is null && currency2 is not null)
            return false;

        return currency1!.Equals(currency2);
    }

    public static bool operator !=(Currency currency1, Currency currency2) => !(currency1 == currency2);
}
