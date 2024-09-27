namespace YourAppNamespace.Models
{
    public class Meeting
    {
        public int MeetingId { get; set; }
        public int DeveloperId { get; set; }
        public int CustomerId { get; set; }
        public DateTime ScheduledTime { get; set; }
        public int DurationMinutes { get; set; }
        public string Status { get; set; }
        public string Description { get; set; }
    }
}