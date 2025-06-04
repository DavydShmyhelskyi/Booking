using Core.Entities;
using Core;
using Repository;

namespace Repository.Repos
{
    public class WorkspaceTypeInfoRepository : BaseRepository<WorkspaceTypeInfo>
    {
        public WorkspaceTypeInfoRepository(ApplicationDbContext context) : base(context) { }
    }
}