using Data.Entities;
using Data.Repositories;

namespace MemoryProviders.Repositories;

public class UserRepository : EntityRepository<User>, IUserRepository
{
    public User? GetUserByName(string firstName, string secondName)
    {
        foreach (var item in All)
            if (String.Equals(item.FirstName, firstName, StringComparison.InvariantCultureIgnoreCase) &&
                String.Equals(item.SecondName, secondName, StringComparison.InvariantCultureIgnoreCase))
                return item;

        return null;
    }
}
