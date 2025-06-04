using Core.Entities;
using Core;
using Repository;

namespace Repository.Repos
{
    public class PhotoRepository : BaseRepository<Photo>
    {
        public PhotoRepository(ApplicationDbContext context) : base(context) { }
    }
}