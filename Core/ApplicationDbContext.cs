using Microsoft.EntityFrameworkCore;
using Core.Entities;

namespace Core
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Workspace> Workspaces { get; set; }
        public DbSet<Booking> Bookings { get; set; }
        public DbSet<Coworking> Coworkings { get; set; }
        public DbSet<Amenity> Amenities { get; set; }
       // public DbSet<WorkspaceAmenity> WorkspaceAmenities { get; set; }
        public DbSet<Photo> Photos { get; set; }
        public DbSet<WorkspaceType> WorkspaceTypes { get; set; }
        public DbSet<WorkspaceTypeInfo> WorkspaceTypeInfos { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options) { }

       
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {   
                optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=deskbooking;Username=admin;Password=admin");
            }
        }
    }
}