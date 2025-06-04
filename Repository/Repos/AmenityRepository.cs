using Core.Entities;
using Core;
using Repository;

namespace Repository.Repos
{
    public class AmenityRepository : BaseRepository<Amenity>
    {
        public AmenityRepository(ApplicationDbContext context) : base(context) { }
    }
}