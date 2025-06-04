using Core.Entities;
using Core;
using Repository;

namespace Repository.Repos
{
    public class WorkspaceRepository : BaseRepository<Workspace>
    {
        public WorkspaceRepository(ApplicationDbContext context) : base(context) { }
    }
}