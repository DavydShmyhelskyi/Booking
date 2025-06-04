using Core.Enums;

namespace Core.Entities
{
    public class Booking
    {
        public int Id { get; set; }
        public string UserName { get; set; } = null!;
        public string UserEmail { get; set; } = null!;
        public int WorkspaceId { get; set; }
        public Workspace Workspace { get; set; } = null!;
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public BookingStatus Status { get; set; } = BookingStatus.Active;
    }
}
