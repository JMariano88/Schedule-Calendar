namespace YourAppNamespace.Models
{
    public class Project
    {
        public int ProjectId { get; set; }
        public int DeveloperId { get; set; }
        public int CustomerId { get; set; }
        public string ProjectName { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string Status { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
