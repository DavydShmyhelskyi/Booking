namespace Core.Entities
{
    public class Coworking
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string? Address { get; set; }
        public ICollection<Workspace> Workspaces { get; set; } = new List<Workspace>();
    }
}