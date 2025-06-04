namespace Core.Entities
{
    public class Workspace
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public int WorkspaceTypeInfoId { get; set; }
        public WorkspaceTypeInfo WorkspaceTypeInfo { get; set; } = null!;
        public int Capacity { get; set; }
        public int? CoworkingId { get; set; }
        public Coworking? Coworking { get; set; }
        public ICollection<Booking> Bookings { get; set; } = new List<Booking>();
        public ICollection<Photo> Photos { get; set; } = new List<Photo>();
        public ICollection<Amenity> Amenities { get; set; } = new List<Amenity>();
    }
}