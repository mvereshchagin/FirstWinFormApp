namespace Data.Entities;

public class User : IEntityItem
{
    public int Id { get; set; }

    public string FirstName { get; set; } = null!;

    public string SecondName { get; set; } = null!;

    public string Address { get; set; } = null!;

    public List<Posting> Postings { get; set; } = new();

    public override string ToString()
    {
        return $"{FirstName} {SecondName}, {Address}";
    }
}
