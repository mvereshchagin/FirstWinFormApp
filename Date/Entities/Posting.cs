namespace Data.Entities;

public class Posting : IEntityItem
{
    public int Id { get; set; }

    public Currency Currency { get; set; } = null!;

    public User User { get; set; } = null!;

    public User? OtherUser { get; set; }

    public string? Description { get; set; }

    public DateTime DateTime { get; set; }

    public double Amount { get; set; }
}
