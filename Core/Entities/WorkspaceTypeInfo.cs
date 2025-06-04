namespace Core.Entities
{
    public class WorkspaceTypeInfo
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string? Description { get; set; }
        public int? DefaultCapacity { get; set; }
    }
}