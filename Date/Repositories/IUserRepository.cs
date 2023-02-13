using Data.Entities;

namespace Data.Repositories;

public interface IUserRepository : IEntityRepository<User>
{
    User? GetUserByName(string firstName, string secondName);
}
