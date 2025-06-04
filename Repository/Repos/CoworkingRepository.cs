using Core.Entities;
using Core;
using Repository;

namespace Repository.Repos
{
    public class CoworkingRepository : BaseRepository<Coworking>
    {
        public CoworkingRepository(ApplicationDbContext context) : base(context) { }
    }
}