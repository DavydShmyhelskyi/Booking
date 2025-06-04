namespace Core.Entities
{
    public class Photo
    {
        public int Id { get; set; }
        public string PhotoUrl { get; set; } = null!;
        public int WorkspaceId { get; set; }
        public Workspace Workspace { get; set; } = null!;
    }
}