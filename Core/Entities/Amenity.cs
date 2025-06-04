namespace Core.Entities
{
    public class Amenity
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public ICollection<Workspace> Workspaces { get; set; } = new List<Workspace>();
    }
}