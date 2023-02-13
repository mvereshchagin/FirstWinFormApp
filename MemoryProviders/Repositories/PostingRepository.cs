using Data.Entities;
using Data.Repositories;

namespace MemoryProviders.Repositories;

public class PostingRepository : EntityRepository<Posting>, IPostingRepository
{
}
