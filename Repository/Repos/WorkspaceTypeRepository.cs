using Core.Entities;
using Core;
using Repository;

namespace Repository.Repos
{
    public class WorkspaceTypeRepository : BaseRepository<WorkspaceType>
    {
        public WorkspaceTypeRepository(ApplicationDbContext context) : base(context) { }
    }
}